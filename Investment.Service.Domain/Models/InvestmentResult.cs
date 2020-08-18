using System;
using System.Collections.Generic;
using System.Text;

namespace Investment.Service.Domain.Models
{
    public class InvestmentResult
    {
        public decimal InvestmentReturn { get; set; }
        public decimal Fees { get; set; }
    }
}
