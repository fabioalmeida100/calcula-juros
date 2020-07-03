using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calculajuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromQuery] decimal valorInicial, int meses)
        {
            return Ok(valorInicial.ToString() + " | " + meses);
        }

        [HttpGet("ShowMeTheCode")]
        public IActionResult ShowMeTheCode()
        {
            return Ok("https://github.com/fabioalmeida100/calcula-juros.git");
        }
    }
}