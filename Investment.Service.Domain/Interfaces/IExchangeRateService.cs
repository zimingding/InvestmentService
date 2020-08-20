namespace Investment.Service.Domain.Interfaces
{
    public interface IExchangeRateService
    {
        decimal Exchange(string fromCurrency, string toCurrency, decimal value);
    }
}
