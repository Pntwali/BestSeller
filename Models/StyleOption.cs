using System.ComponentModel.DataAnnotations;

namespace BestSeller.StyleManagement.Models
{
    public class StyleOption
    {
        [Key]
        public Guid Id { get; set; }
        public string StyleOptionName { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}