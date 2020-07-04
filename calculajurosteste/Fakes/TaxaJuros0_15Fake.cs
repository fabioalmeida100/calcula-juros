using calculajuros.Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace calculajurostest.Fakes
{
    public class TaxaJuros0_15Fake : ITaxaJuros
    {
        public double ObterTaxaJuros()
        {
            return 0.15;
        }
    }
}
