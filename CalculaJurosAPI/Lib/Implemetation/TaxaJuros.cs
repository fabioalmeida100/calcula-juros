using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.Net.Http;

namespace CalculaJurosAPI.Lib.Implemetation
{
    public class TaxaJuros: ITaxaJuros
    {
        private readonly string _urlApiTaxaJuros;
        public TaxaJuros(IConfiguration configuration) 
        {
            _urlApiTaxaJuros = configuration["ApiTaxaJuros"];
        }

        public double ObterTaxaJuros()
        {
            double taxaJuros = 0;

            var client = new HttpClient();

            try
            {
                client.BaseAddress = new Uri(_urlApiTaxaJuros);
                var response = client.GetAsync("taxajuros").Result;

                if (response.IsSuccessStatusCode)
                {
                    taxaJuros = Convert.ToDouble(response.Content.ReadAsStringAsync().Result, CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                taxaJuros = 0;
                throw new Exception(ex.Message + "\n" + ex.StackTrace);
            }


            return taxaJuros;
        }
    }
}
