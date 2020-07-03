using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculajuros.Lib
{
    public class CalculoJuros
    {
        private readonly decimal _valorInicial;
        private readonly int _meses;

        public CalculoJuros(decimal valorInicial, int meses)
        {
            _valorInicial = valorInicial;
            _meses = meses;
        }

        public decimal JurosComposto()
        {
            var baseCalculo = (double)_valorInicial * Math.Pow((1 + 0.01), _meses);
            return Convert.ToDecimal(baseCalculo); 
        }

    }
}
