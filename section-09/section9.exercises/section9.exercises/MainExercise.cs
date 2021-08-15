using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using section9.exercises.Entities;
using section9.exercises.Entities.Enums;

namespace section9.exercises
{
    class MainExercise
    {
        public static void Exercise()
        {
            Console.Write("\nEnter department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("\nEnter worker data");
            Console.WriteLine("-----------------");

            Console.Write("Name: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: $ ");
            double workerBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);

            Worker worker = new Worker(workerName, workerLevel, workerBaseSalary, department);

            Console.Write("\nHow many contracts to this worker? ");
            int quantityContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityContracts; i++)
            {
                Console.WriteLine($"\nEnter #{i} contract data:");
                Console.WriteLine("-----------------------");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double contractValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int contractHours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(contractDate, contractValuePerHour, contractHours);

                worker.AddContract(contract);
            }

            Console.Write("\n\nEnter month and year to calculate income (MM/YYYY): ");
            string dateCalculateIncome = Console.ReadLine();
            int monthCalculateIncome = int.Parse(dateCalculateIncome.Substring(0, 2));
            int yearCalculateIncome = int.Parse(dateCalculateIncome.Substring(3));

            Console.WriteLine($"\n\nName: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {dateCalculateIncome}: $ {worker.Income(yearCalculateIncome, monthCalculateIncome).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
