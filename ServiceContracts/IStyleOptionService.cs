using BestSeller.StyleManagement.Models;

namespace BestSeller.StyleManagement.ServiceContracts
{
    // IStyleOptionService interface
    public interface IStyleOptionService
    {
        Task<IEnumerable<StyleOption>> GetAllStyleOptionsAsync();
        Task<StyleOption> GetStyleOptionByIdAsync(Guid id);
    }

}
