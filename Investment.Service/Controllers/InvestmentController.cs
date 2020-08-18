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

        public InvestmentController(IInvestmentService investmentOptionService)
        {
            _investmentService = investmentOptionService;
        }

        [HttpGet("options")]
        public IEnumerable<InvestmentOption> GetOptions()
        {
            return _investmentService.GetInvestmentOptions();
        }

        [HttpPost("calculate")]
        public InvestmentResult CalculateROI(List<InvestmentDetail> investmentDetails)
        {
            return _investmentService.CalculateResult(investmentDetails);
        }
    }
}
