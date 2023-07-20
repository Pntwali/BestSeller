using BestSeller.StyleManagement.DataContracts;
using BestSeller.StyleManagement.Models;
using BestSeller.StyleManagement.ServiceContracts;

namespace BestSeller.StyleManagement.Services
{
    // Implement the services
    public class StyleService : IStyleService
    {
        private readonly IStyleRepository _styleRepository;

        public StyleService(IStyleRepository styleRepository)
        {
            _styleRepository = styleRepository;
        }

        public async Task<IEnumerable<Style>> GetAllStylesAsync()
        {
            return await _styleRepository.GetAllStylesAsync();
        }

        public async Task<Style> GetStyleByIdAsync(Guid id)
        {
            return await _styleRepository.GetStyleByIdAsync(id);
        }
    }

}
