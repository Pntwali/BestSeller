using BestSeller.StyleManagement.DataContracts;
using BestSeller.StyleManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BestSeller.StyleManagement.Data
{
    // StyleRepository
    public class StyleRepository : IStyleRepository
    {
        private readonly ApplicationDbContext _context;

        public StyleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Style>> GetAllStylesAsync()
        {
            return await _context.Styles.ToListAsync();
        }

        public async Task<Style> GetStyleByIdAsync(Guid id)
        {
            return await _context.Styles
                .Include(x => x.RelatedStyleOptions)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }

    // StyleOptionRepository
}
