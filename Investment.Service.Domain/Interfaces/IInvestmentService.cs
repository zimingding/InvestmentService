using Investment.Service.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Domain.Interfaces
{
    public interface IInvestmentService
    {
        IEnumerable<InvestmentOption> GetInvestmentOptions();
        InvestmentResult CalculateResult(List<InvestmentDetail> investmentDetails);
    }
}
