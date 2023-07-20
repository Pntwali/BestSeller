using BestSeller.StyleManagement.Models;
using BestSeller.StyleManagement.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestSeller.StyleManagement.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StylesController : ControllerBase
    {
        private readonly IStyleService _styleService;

        public StylesController(IStyleService styleService)
        {
            _styleService = styleService;
        }

        // GET: api/Styles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Style>>> GetStyles()
        {
            var styles = await _styleService.GetAllStylesAsync();
            if (styles == null)
            {
                return NotFound();
            }
            return Ok(styles);
        }

        // GET: api/Styles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Style>> GetStyle(Guid id)
        {

            var style = await _styleService.GetStyleByIdAsync(id);

            if (style == null)
            {
                return NotFound();
            }

            return Ok(style);
        }

    }
}
