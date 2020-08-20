using System.ComponentModel;

namespace Investment.Service.Domain.Enum
{
    public enum InvestmentOptionEnum
    {
        [Description("Cash investments")]
        CashInvestment = 1,

        [Description("Fixed interest")]
        FixedInterest = 2,

        [Description("Shares")]
        Shares = 3,

        [Description("Managed funds")]
        ManagedFunds = 4,

        [Description("Exchange traded funds (ETFs)")]
        ExchangeTradedFunds = 5,

        [Description("Investment bonds")]
        InvestmentBonds = 6,

        [Description("Annuities")]
        Annuities = 7,

        [Description("Listed investment companies (LICs)")]
        ListedInvestmentCompanies = 8,

        [Description("Real estate investment trusts")]
        RealEstateInvestmentTrusts = 9
    }
}
