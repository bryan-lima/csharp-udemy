using System;
using System.Collections.Generic;
using System.Text;

namespace section6.exercises
{
    class Employee
    {
        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public int ID { get; }

        public string Name { get; set; }

        public double Salary { get; private set; }

        public void SalaryIncrease(double increasePercentage)
        {
            Salary += Salary / 100 * increasePercentage;
        }
    }
}
