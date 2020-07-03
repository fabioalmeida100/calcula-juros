using calculajuros.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculajuros.Business.Implementation
{
    public class CalculoJurosBusiness : ICalculoJurosBusiness
    {
        public decimal ObterJurosComposto(decimal valorInicial, int meses)
        {
            var calculaJuros = new CalculoJuros(valorInicial, meses);
            return Math.Truncate(100 * calculaJuros.JurosComposto())/100;
        }
    }
}
