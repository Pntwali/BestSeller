using BestSeller.StyleManagement.Models;

namespace BestSeller.StyleManagement.ServiceContracts
{
    // IStyleService interface
    public interface IStyleService
    {
        Task<IEnumerable<Style>> GetAllStylesAsync();
        Task<Style> GetStyleByIdAsync(Guid id);
    }

}
