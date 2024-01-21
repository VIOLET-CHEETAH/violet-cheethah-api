using Microsoft.AspNetCore.Mvc;
using violet.cheetah.Domain.Catalog;

namespace violet.cheetah.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("Hello, world!");
        }
    }
}
