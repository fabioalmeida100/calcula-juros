using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculajuros.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

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

        /// <summary>
        ///     Retorna o cálculo dos Juros Compostos
        /// </summary>
        /// <param name="valorInicial">Valor inicial aplicado</param>
        /// <param name="meses">Meses (valor inteiro)</param>
        /// <response code="200">Retorna o valor calculado do juros composto</response>
        /// <response code="500">Possível problema de comunicação com a API de Taxa de Juros. Verificar URL da API no arquivo appsettings.json</response>            
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Index([FromQuery] decimal valorInicial, int meses)
        {
            return Ok(_calculoJuros.ObterJurosComposto(valorInicial, meses).ToString("N2"));
        }

        /// <summary>
        ///     Retorna a URL do projeto no Github
        /// </summary>
        /// <response code="200">Retorna a URL do projeto no Github</response>
        [HttpGet("ShowMeTheCode")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ShowMeTheCode()
        {
            return Ok("https://github.com/fabioalmeida100/calcula-juros.git");
        }
    }
}