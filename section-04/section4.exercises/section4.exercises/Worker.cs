using System;
using System.Collections.Generic;
using System.Text;

namespace section4.exercises
{
    class Worker
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void RaiseSalary(double percentage)
        {
            GrossSalary += (GrossSalary * percentage / 100.0);
        }

        public override string ToString()
        {
            return Name
                    + " | R$ "
                    + NetSalary().ToString("F2");
        }
    }
}
