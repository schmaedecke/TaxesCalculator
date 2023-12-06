using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator.Entities {
    class Individual : TaxPayer {

        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            if(AnnualIncome < 20000.00) {
                return AnnualIncome * 0.15 - HealthExpenditures * 0.5;
            } else {
                return AnnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
