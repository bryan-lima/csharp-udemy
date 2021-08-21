using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.AbstractMethods.Entities
{
    class Individual : TaxPayer
    {
        public double MedicalExpenses { get; set; }

        public Individual(string name, double annualIncome, double medicalExpenses) : base(name, annualIncome)
        {
            MedicalExpenses = medicalExpenses;
        }

        public override double TaxToPay()
        {
            double percentageOfTaxPayable = 0.15;

            if (AnnualIncome >= 20000.0)
            {
                percentageOfTaxPayable = 0.25;
            }

            if (MedicalExpenses > 0.0)
            {
                return (AnnualIncome * percentageOfTaxPayable) - (MedicalExpenses * 0.5);
            }
            else
            {
                return (AnnualIncome * percentageOfTaxPayable);
            }
        }
    }
}
