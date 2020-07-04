using calculajuros.Lib;
using calculajuros.Lib.Implemetation;
using System;
using System.Globalization;

namespace calculajuros.Business.Implementation
{
    public class CalculoJurosBusiness : ICalculoJurosBusiness
    {
        private readonly ITaxaJuros _taxaJuros;

        public CalculoJurosBusiness(ITaxaJuros taxaJuros)
        {
            _taxaJuros = taxaJuros;
        }

        public decimal ObterJurosComposto(decimal valorInicial, int meses)
        {
            var calculaJuros = new CalculoJuros(valorInicial, meses, _taxaJuros);
            return calculaJuros.JurosComposto();
        }
    }
}
