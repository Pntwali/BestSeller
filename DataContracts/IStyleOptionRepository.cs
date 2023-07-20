using BestSeller.StyleManagement.Models;

namespace BestSeller.StyleManagement.DataContracts
{
    public interface IStyleOptionRepository
    {
        Task<IEnumerable<StyleOption>> GetAllStyleOptionsAsync();
        Task<StyleOption> GetStyleOptionByIdAsync(Guid id);
    }
}
