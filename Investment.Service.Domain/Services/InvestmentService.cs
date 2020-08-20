using Investment.Service.Domain.Enum;
using Investment.Service.Domain.Interfaces;
using Investment.Service.Domain.Models;
using Investment.Service.Domain.ROICalculators;
using System.Collections.Generic;

namespace Investment.Service.Domain.Services
{
    public class InvestmentService : IInvestmentService
    {
        private readonly Dictionary<InvestmentOptionEnum, IROICalculator> _returnCalculatorDictionary =
            new Dictionary<InvestmentOptionEnum, IROICalculator> {
                [InvestmentOptionEnum.CashInvestment] = new CashInvestmentsCalculator(),
                [InvestmentOptionEnum.FixedInterest] = new FixedInterestCalculator(),
                [InvestmentOptionEnum.Shares] = new SharesCalculator(),
                [InvestmentOptionEnum.ManagedFunds] = new ManagedFundsCalculator(),
                [InvestmentOptionEnum.ExchangeTradedFunds] = new ExchangeTradedFundsCalculator(),
                [InvestmentOptionEnum.InvestmentBonds] = new InvestmentBondsCalculator(),
                [InvestmentOptionEnum.Annuities] = new AnnuitiesCalculator(),
                [InvestmentOptionEnum.ListedInvestmentCompanies] = new ListedInvestmentCompaniesCalculator(),
                [InvestmentOptionEnum.RealEstateInvestmentTrusts] = new RealEstateInvestmentTrustsCalculator()
        };

        public InvestmentResult CalculateResult(List<InvestmentDetail> investmentDetails)
        {
            InvestmentResult result = new InvestmentResult();
            foreach (var investmentDetail in investmentDetails)
            {
                var investmentOptionId = investmentDetail.InvestmentOptionId;
                (var investmentReturn, var fee) = _returnCalculatorDictionary[(InvestmentOptionEnum)investmentOptionId]
                    .Calculate(investmentDetail.Amount, investmentDetail.Percentage);
                result.InvestmentReturn += investmentReturn;
                result.Fees += fee;
            }

            return result;
        }

        public IEnumerable<InvestmentOption> GetInvestmentOptions()
        {
            List<InvestmentOption> investmentOptions = new List<InvestmentOption>();
            foreach (InvestmentOptionEnum investmentOption in System.Enum.GetValues(typeof(InvestmentOptionEnum)))
            {
                investmentOptions.Add(
                    new InvestmentOption {
                        Id = (int)investmentOption,
                        Name = investmentOption.GetDescription()
                    }
                );
            }

            return investmentOptions;
        }
    }
}
