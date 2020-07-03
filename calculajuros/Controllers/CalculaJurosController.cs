using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculajuros.Business;
using Microsoft.AspNetCore.Mvc;

namespace calculajuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : Controller
    {
        private ICalculoJurosBusiness _calculoJuros;

        public CalculaJurosController(ICalculoJurosBusiness calculoJuros)
        {
            _calculoJuros = calculoJuros;
        }

        [HttpGet]
        public IActionResult Index([FromQuery] decimal valorInicial, int meses)
        {

            return Ok(_calculoJuros.ObterJurosComposto(valorInicial, meses));
        }

        [HttpGet("ShowMeTheCode")]
        public IActionResult ShowMeTheCode()
        {
            return Ok("https://github.com/fabioalmeida100/calcula-juros.git");
        }
    }
}