using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Service.Domain.Interfaces
{
    public interface IExchangeRateRepository
    {
        Task<decimal> GetExchangeRate(string fromCurrency, string toCurrency);
    }
}
