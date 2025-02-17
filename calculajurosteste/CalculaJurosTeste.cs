using CalculaJurosAPI.Lib.Implemetation;
using CalculaJurosTeste.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculaJurosTeste
{
    [TestClass]
    public class CalculaJurosTeste
    {
        private readonly TaxaJuros0_01Fake _taxaJuros0_virgula_01;
        private readonly TaxaJuros0_10Fake _taxaJuros0_virgula_10;
        private readonly TaxaJuros0_15Fake _taxaJuros0_virgula_15;
        private readonly TaxaJurosZero _taxaJurosZero;

        public CalculaJurosTeste()
        {
            _taxaJuros0_virgula_01 = new TaxaJuros0_01Fake();
            _taxaJuros0_virgula_10 = new TaxaJuros0_10Fake();
            _taxaJuros0_virgula_15 = new TaxaJuros0_15Fake();
            _taxaJurosZero = new TaxaJurosZero();
        }

        [TestMethod]
        public void calcular_juros_composto_com_taxa_0_01_porcento()
        {
           var _calculaJuros_100_reais_5_meses = new CalculoJuros(100, 5, _taxaJuros0_virgula_01);
           Assert.AreEqual((decimal)105.10, _calculaJuros_100_reais_5_meses.JurosComposto()); 
        }

        [TestMethod]
        public void calcular_juros_composto_com_taxa_0_10_porcento()
        {
            var _calculaJuros_100_reais_5_meses = new CalculoJuros(100, 5, _taxaJuros0_virgula_10);
            Assert.AreEqual((decimal)161.05, _calculaJuros_100_reais_5_meses.JurosComposto());
        }

        [TestMethod]
        public void calcular_juros_composto_com_taxa_0_15_porcento()
        {
            var _calculaJuros_100_reais_5_meses = new CalculoJuros(100, 5, _taxaJuros0_virgula_15);
            Assert.AreEqual((decimal)201.13, _calculaJuros_100_reais_5_meses.JurosComposto());
        }

        [TestMethod]
        public void calcular_juros_composto_com_valor_100_reais_5_meses_taxa_zero()
        {
            var _calculaJuros_100_reais_5_meses = new CalculoJuros(100, 5, _taxaJurosZero);
            Assert.AreEqual((decimal)100, _calculaJuros_100_reais_5_meses.JurosComposto());
        }

        [TestMethod]
        public void calcular_juros_composto_com_valor_100_reais_10_meses_taxa_zero()
        {
            var _calculaJuros_100_reais_5_meses = new CalculoJuros(100, 10, _taxaJurosZero);
            Assert.AreEqual((decimal)100, _calculaJuros_100_reais_5_meses.JurosComposto());
        }

        [TestMethod]
        public void calcular_juros_composto_com_valor_0_reais_10_meses_taxa_15_porcento()
        {
            var _calculaJuros_0_reais_10_meses = new CalculoJuros(0, 10, _taxaJuros0_virgula_15);
            Assert.AreEqual(0, _calculaJuros_0_reais_10_meses.JurosComposto());
        }

        [TestMethod]
        public void calcular_juros_composto_com_valor_100_12_reais_7_meses_taxa_15_porcento()
        {
            var _calculaJuros_100_12_reais_7_meses = new CalculoJuros((decimal)100.12, 7, _taxaJuros0_virgula_15);
            Assert.AreEqual((decimal)266.32, _calculaJuros_100_12_reais_7_meses.JurosComposto());
        }
    }
}
