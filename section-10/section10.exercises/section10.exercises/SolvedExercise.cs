﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using section10.exercises.Entities;

namespace section10.exercises
{
    class SolvedExercise
    {
        public static void InheritanceAndPolymorphism()
        {
            /*
            
            Uma empresa possui funcionários próprios e terceirizados.
            Para cada funcionário, deseja - se registrar nome, horas trabalhadas e valor por hora.
            Funcionários terceirizados possuem ainda uma despesa adicional.

            O pagamento dos funcionários corresponde ao valor da hora multiplicado pelas horas trabalhadas, sendo que os funcionários terceirizados ainda recebem um bônus correspondente a 110 % de sua despesa adicional.
            
            Fazer um programa para ler os dados de N funcionários(N fornecido pelo usuário) e armazená-los em uma lista.
            Depois de ler todos os dados, mostrar nome e pagamento de cada funcionário na mesma ordem em que foram digitados.
            
            Construa o programa conforme projeto abaixo.


                      +---------------------------+
                      |          Employee         |
                      +---------------------------+
                      | - name: String            |
                      | - valuePerHour: Double    |
                      +---------------------------+
                      | + payment(): Double       |
                      +---------------------------+
                                  /|\
                                   |
                                   |
                   +---------------------------------+
                   |       OutsourcedEmployee        |
                   +---------------------------------+
                   | - additionalCharge: Double      |
                   +---------------------------------+
                   | + payment(): Double             |
                   +---------------------------------+

            */

            Console.Write("\nEnter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"\n\nEmployee #{i} data:");
                Console.WriteLine("-----------------");

                bool hasOutsourced = false;

                while (true)
                {
                    Console.Write("\nOutsourced (y/n)? ");
                    string answerIfIsOutsourced = Console.ReadLine();

                    if (answerIfIsOutsourced.Trim().ToUpper() == "Y")
                    {
                        hasOutsourced = true;
                        break;
                    }
                    else if (answerIfIsOutsourced.Trim().ToUpper() == "N")
                    {
                        hasOutsourced = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer! Just type Y or N.");
                    }
                }

                Console.Write("Name: ");
                string employeeName = Console.ReadLine();

                Console.Write("Hours: ");
                int employeeHours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: $ ");
                double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee employee;

                if (hasOutsourced)
                {
                    Console.Write("Additional charge: $ ");
                    double outsourcedEmployeeAdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employee = new OutsourcedEmployee(employeeName, employeeHours, employeeValuePerHour, outsourcedEmployeeAdditionalCharge);
                }
                else
                {
                    employee = new Employee(employeeName, employeeHours, employeeValuePerHour);
                }

                employeeList.Add(employee);
            }

            Console.WriteLine("\n\n\n                    PAYMENTS:");
            Console.WriteLine("-------------------------------------------------");

            foreach (Employee employee in employeeList)
            {
                if (employee is Employee)
                {
                    Console.WriteLine(employee);
                }
                else
                {
                    OutsourcedEmployee outsourcedEmployee = employee as OutsourcedEmployee;
                    Console.WriteLine(outsourcedEmployee);
                }
            }
        }
    }
}
