using System.ComponentModel.DataAnnotations;

namespace BestSeller.StyleManagement.Models
{
    public class Style
    {

        public Guid Id { get; set; }
        public string? StyleName { get; set; }
        public int StyleNumber { get; set; }
        public List<StyleOption> RelatedStyleOptions { get; set; }
    }
}
