using CalculaJurosAPI.Lib;

namespace CalculaJurosTeste.Fakes
{
    public class TaxaJuros0_10Fake : ITaxaJuros
    {
        public double ObterTaxaJuros()
        {
            return 0.10;
        }
    }
}
