using BestSeller.StyleManagement.Models;

namespace BestSeller.StyleManagement.DataContracts
{
    public interface IStyleRepository
    {
        Task<IEnumerable<Style>> GetAllStylesAsync();
        Task<Style> GetStyleByIdAsync(Guid id);
    }
}
