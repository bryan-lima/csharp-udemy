using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercise.AbstractMethods.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }

        public double AnnualIncome { get; set; }

        public TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TaxToPay();

        public override string ToString()
        {
            return Name + ": $ " + TaxToPay().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
