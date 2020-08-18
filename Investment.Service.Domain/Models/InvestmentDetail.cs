using Investment.Service.Domain.Models;

namespace Investment.Service.Domain
{
    public class Investment
    {
        public decimal Amount { get; set; }
    }

    public class InvestmentDetail : Investment
    {
        public InvestmentOption InvestmentOption { get; set; }
        public decimal Percentage { get; set; }
    }
}
