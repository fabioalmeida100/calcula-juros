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
            client.BaseAddress = new Uri(_urlApiTaxaJuros);            
            var response = client.GetAsync("taxajuros").Result;
            
            if (response.IsSuccessStatusCode)
            {
                taxaJuros = Convert.ToDouble(response.Content.ReadAsStringAsync().Result, CultureInfo.InvariantCulture);
            }

            return taxaJuros;
        }
    }
}
