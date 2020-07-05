using CalculaJurosAPI.Lib;

namespace CalculaJurosTeste.Fakes
{
    public class TaxaJuros0_01Fake : ITaxaJuros
    {
        public double ObterTaxaJuros()
        {
            return 0.01;
        }
    }
}
