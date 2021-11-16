using section17.exercises.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace section17.exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Fazer um programa para ler os dados (nome, email e salário) de funcionários a partir de um arquivo em formato .csv.
            
            Em seguida mostrar, em ordem alfabética, o email dos funcionários cujo salário seja superior a um dado valor fornecido pelo usuário.

            Mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'.

            +------------------+
            |     Employee     |
            +------------------+
            | - name: String   |
            | - email: String  |
            | - salary: Double |
            +------------------+
            +------------------+

            */

            Console.Write("\nEnter the full file path: ");
            string path = Console.ReadLine();

            Console.Write("\nEnter salary: $ ");
            double chosenSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {

                    while (!streamReader.EndOfStream)
                    {
                        string[] employeeCSV = streamReader.ReadLine()
                                                           .Split(",");

                        Employee employee = new Employee(name: employeeCSV[0], 
                                                         email: employeeCSV[1], 
                                                         salary: double.Parse(employeeCSV[2], CultureInfo.InvariantCulture));

                        employees.Add(employee);
                    }

                    IEnumerable<string> emails = employees.Where(employee => employee.Salary > chosenSalary)
                                                          .OrderBy(employee => employee.Email)
                                                          .Select(employee => employee.Email);

                    Console.WriteLine($"\nEmail of people whose salary is more than {chosenSalary.ToString("F2", CultureInfo.InvariantCulture)}");
                    foreach(string email in emails)
                        Console.WriteLine(email);

                    double wageSum = employees.Where(employee => employee.Name.StartsWith("M"))
                                              .Sum(employee => employee.Salary);

                    Console.WriteLine($"\nSum of salary of people whose name starts with 'M': {wageSum.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
