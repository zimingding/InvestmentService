using Investment.Service.Domain;
using Investment.Service.Domain.Interfaces;
using Investment.Service.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestmentController
    {
        private readonly IInvestmentService _investmentService;
        private readonly IExchangeRateService _exchangeRateService;

        public InvestmentController(IInvestmentService investmentOptionService, IExchangeRateService exchangeRateService)
        {
            _investmentService = investmentOptionService;
            _exchangeRateService = exchangeRateService;
        }

        [HttpGet("options")]
        public IEnumerable<InvestmentOption> GetOptions()
        {
            return _investmentService.GetInvestmentOptions();
        }

        [HttpPost("calculate")]
        public InvestmentResult CalculateROI([FromBody] CalculateROIRequest request)
        {
            var investmentResult = _investmentService.CalculateResult(request.InvestmentDetails);

            var exchangedResult = new InvestmentResult
            {
                InvestmentReturn = _exchangeRateService.Exchange("AUD", "USD", investmentResult.InvestmentReturn),
                Fees = _exchangeRateService.Exchange("AUD", "USD", investmentResult.Fees)
            };
            return exchangedResult;
        }
    }
}
