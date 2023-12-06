using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator.Entities {
    abstract class TaxPayer {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayer() { }

        public TaxPayer(string name, double annualIncome) {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
        
    }
}
