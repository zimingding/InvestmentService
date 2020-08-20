using Investment.Service.Domain;
using Investment.Service.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Service
{
    public class CalculateROIRequest
    {
        public List<InvestmentDetail> InvestmentDetails { get; set; }
    }
}
