using Investment.Service.Domain.Interfaces;
using Investment.Service.Domain.Models;
using Investment.Service.Domain.ROICalculators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Domain.Services
{
    public class InvestmentService : IInvestmentService
    {
        public InvestmentResult CalculateResult(List<InvestmentDetail> investmentDetails)
        {
            InvestmentResult result = new InvestmentResult();
            foreach (var investmentDetail in investmentDetails)
            {
                (var investmentReturn, var fee) = investmentDetail.InvestmentOption.ROICalculator.Calculate(investmentDetail.Amount, investmentDetail.Percentage);
                result.InvestmentReturn += investmentReturn;
                result.Fees += fee;
            }

            return result;
        }

        public IEnumerable<InvestmentOption> GetInvestmentOptions()
        {
            return new[] {
                new InvestmentOption("Cash investments", 1, new CashInvestmentsCalculator()),
                new InvestmentOption("Fixed interest", 2, new FixedInterestCalculator()),
                new InvestmentOption("Shares", 3, new SharesCalculator()),
                new InvestmentOption("Managed funds", 4, new ManagedFundsCalculator()),
                new InvestmentOption("Exchange traded funds (ETFs)", 5, new ExchangeTradedFundsCalculator()),
                new InvestmentOption("Investment bonds", 6, new InvestmentBondsCalculator()),
                new InvestmentOption("Annuities", 7, new AnnuitiesCalculator()),
                new InvestmentOption("Listed investment companies (LICs)", 8, new ListedInvestmentCompaniesCalculator()),
                new InvestmentOption("Real estate investment trusts", 9, new RealEstateInvestmentTrustsCalculator())
            };
        }
    }
}
