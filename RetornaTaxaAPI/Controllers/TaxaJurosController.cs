using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using System;

namespace RetornaTaxaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : Controller
    {
        /// <summary>
        ///     Retorna o valor da taxa de juros atual
        /// </summary>
        /// <response code="200">Valor da taxa de juros (Ex: 0.01)</response>
        [HttpGet]
        [SwaggerResponse((200), Type = typeof(string))]
        public IActionResult Index()
        {
            return Ok("0.01");
        }
    }
}