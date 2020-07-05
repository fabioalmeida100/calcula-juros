using CalculaJurosAPI.Lib;

namespace CalculaJurosTeste.Fakes
{
    public class TaxaJurosZero : ITaxaJuros
    {
        public double ObterTaxaJuros()
        {
            return 0;
        }
    }
}
