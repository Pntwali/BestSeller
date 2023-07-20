using BestSeller.StyleManagement.DataContracts;
using BestSeller.StyleManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BestSeller.StyleManagement.Data
{
    // StyleRepository
    public class StyleOptionRepository : IStyleOptionRepository
    {
        private readonly ApplicationDbContext _context;

        public async Task<IEnumerable<StyleOption>> GetAllStyleOptionsAsync()
        {
            return await _context.StyleOptions.ToListAsync();
        }

        public async Task<StyleOption> GetStyleOptionByIdAsync(Guid id)
        {
            return await _context.StyleOptions
            .FirstOrDefaultAsync(x => x.Id == id);
        }
    }

    // StyleOptionRepository
    

}
