using CalculaJurosAPI.Lib;

namespace CalculaJurosTeste.Fakes
{
    public class TaxaJuros0_15Fake : ITaxaJuros
    {
        public double ObterTaxaJuros()
        {
            return 0.15;
        }
    }
}
