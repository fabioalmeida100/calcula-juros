using Microsoft.AspNetCore.Mvc;

namespace retornajuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("0.01");
        }
    }
}