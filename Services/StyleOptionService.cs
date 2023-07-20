using BestSeller.StyleManagement.DataContracts;
using BestSeller.StyleManagement.Models;
using BestSeller.StyleManagement.ServiceContracts;

namespace BestSeller.StyleManagement.Services
{
    public class StyleOptionService : IStyleOptionService
    {
        private readonly IStyleOptionRepository _styleOptionRepository;

        public StyleOptionService(IStyleOptionRepository styleOptionRepository)
        {
            _styleOptionRepository = styleOptionRepository;
        }

        public async Task<IEnumerable<StyleOption>> GetAllStyleOptionsAsync()
        {
            return await _styleOptionRepository.GetAllStyleOptionsAsync();
        }

        public async Task<StyleOption> GetStyleOptionByIdAsync(Guid id)
        {
            return await _styleOptionRepository.GetStyleOptionByIdAsync(id);
        }
    }

}
