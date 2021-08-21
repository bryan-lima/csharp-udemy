using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.AbstractMethods.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees) :  base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxToPay()
        {
            double percentageOfTaxPayable = 0.16;

            if (NumberOfEmployees > 10)
            {
                percentageOfTaxPayable = 0.14;
            }

            return AnnualIncome * percentageOfTaxPayable;
        }
    }
}
