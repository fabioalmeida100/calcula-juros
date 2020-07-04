using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculajuros.Lib.Implemetation
{
    public class CalculoJuros: ICalculoJuros
    {
        private readonly decimal _valorInicial;
        private readonly int _meses;
        public readonly ITaxaJuros _taxaJuros;

        public CalculoJuros(decimal valorInicial, int meses, ITaxaJuros taxaJuros)
        {
            _valorInicial = valorInicial;
            _meses = meses;
            _taxaJuros = taxaJuros;
        }

        public decimal JurosComposto()
        {
            var baseCalculo = (double)_valorInicial * Math.Pow((1 + _taxaJuros.ObterTaxaJuros()), _meses);
            return Convert.ToDecimal(baseCalculo); 
        }

    }
}
