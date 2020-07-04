using calculajuros.Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace calculajurostest.Fakes
{
    public class TaxaJurosZero : ITaxaJuros
    {
        public double ObterTaxaJuros()
        {
            return 0;
        }
    }
}
