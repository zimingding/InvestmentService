using Investment.Service.Domain;
using Investment.Service.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Service
{
    public class CalculateROIRequest : IValidatableObject
    {
        public List<InvestmentDetail> InvestmentDetails { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var percentage = 0m;
            foreach (var investment in InvestmentDetails)
                percentage += investment.Percentage;

            if (percentage != 100m)
                yield return new ValidationResult($"Percentage should add up to one hundred");
        }
    }
}
