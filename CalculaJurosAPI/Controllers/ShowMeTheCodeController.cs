using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaJurosAPI.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IShowMeTheCodeBusiness _showMeTheCode;

        public ShowMeTheCodeController(IShowMeTheCodeBusiness showMeTheCode)
        {
            _showMeTheCode = showMeTheCode;
        }

        /// <summary>
        ///     Retorna a URL do projeto no Github
        /// </summary>
        /// <response code="200">Retorna a URL do projeto no Github</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ShowMeTheCode()
        {
            return Ok(_showMeTheCode.ShowMeTheCode());
        }
    }
}