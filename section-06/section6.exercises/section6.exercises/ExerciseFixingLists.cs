using System;
using System.Collections.Generic;
using System.Text;

namespace section6.exercises
{
    class ExerciseFixingLists
    {
        public static void Ex01()
        {
            /*

            Fazer um programa para ler um número inteiro N e depois os dados(id, nome e salario) de N funcionários. Não deve haver repetição de id.
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X.Se o id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
            Lembre - se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. 
            Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.

            */

            Console.Write("\nHow many employees will be registered? ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"\n\nEMPLOYEE #{i + 1}:");
                Console.Write("ID: ");
                int employeeID = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string employeeName = Console.ReadLine();

                Console.Write("Salary: R$ ");
                double employeeSalary = double.Parse(Console.ReadLine());

                employeeList.Add(new Employee(employeeID, employeeName, employeeSalary));
            }

            Console.Write("\n\n\nEnter the employee ID that will have salary increase: ");
            int employeeIdForRaise = int.Parse(Console.ReadLine());

            Employee selectedEmployee = employeeList.Find(employee => employee.ID == employeeIdForRaise);

            if (selectedEmployee != null)
            {
                Console.Write("\nEnter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());

                foreach (Employee employee in employeeList)
                {
                    if (employee.ID == selectedEmployee.ID)
                    {
                        employee.SalaryIncrease(percentage);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nThis ID does not exists!");
            }

            Console.WriteLine("\n\n\n# Update list of employees:");
            
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.ID}, {employee.Name}, R$ {employee.Salary.ToString("F2")}");
            }
        }
    }
}
