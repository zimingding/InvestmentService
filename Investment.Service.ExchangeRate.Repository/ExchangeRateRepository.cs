using Investment.Service.Domain.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Investment.Service.ExchangeRate.Repository
{
    public class ExchangeRateRepository : IExchangeRateRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ExchangeRateRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<decimal> GetExchangeRate(string fromCurrency, string toCurrency)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.exchangeratesapi.io/latest?base={fromCurrency}");
            var client = _httpClientFactory.CreateClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<JToken>(data);

                return (decimal)result["rates"][toCurrency];
            }

            return 1m;
        }
    }
}
