using BestSeller.StyleManagement.Models;
using Duende.IdentityServer.EntityFramework.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BestSeller.StyleManagement.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }

        public DbSet<Style> Styles { get; set; }
        public DbSet<StyleOption> StyleOptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure primary keys
            modelBuilder.Entity<Style>().HasKey(s => s.Id);
            modelBuilder.Entity<StyleOption>().HasKey(so => so.Id);

            // Configure relationships
            modelBuilder.Entity<Style>()
                .HasMany(s => s.RelatedStyleOptions)
                .WithOne()
                .HasForeignKey("StyleId")
                .OnDelete(DeleteBehavior.Cascade); // Adjust the delete behavior according to your requirements

            // Configure other properties
            modelBuilder.Entity<Style>().Property(s => s.StyleName).IsRequired();
            modelBuilder.Entity<StyleOption>().Property(so => so.StyleOptionName).IsRequired();

            // Configure complex properties (ImageUrls)
            modelBuilder.Entity<StyleOption>()
                .Property(so => so.ImageUrls)
                .HasConversion(
                    urls => string.Join(";", urls),
                    value => value.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList()
                );




        }
    }
}