using Investment.Service.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Domain.Services
{
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly IExchangeRateRepository _exchangeRateRepository;

        public ExchangeRateService(IExchangeRateRepository exchangeRateRepository)
        {
            _exchangeRateRepository = exchangeRateRepository;
        }

        public decimal Exchange(string fromCurrency, string toCurrency, decimal value)
        {
            var rate = _exchangeRateRepository.GetExchangeRate(fromCurrency, toCurrency).Result;

            return value * rate;
        }
    }
}
