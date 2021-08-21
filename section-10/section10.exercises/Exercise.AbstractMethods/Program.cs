using System;
using System.Collections.Generic;
using System.Globalization;
using Exercise.AbstractMethods.Entities;

namespace Exercise.AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um, 
            bem como o total de imposto arrecadado.
            
            Os dados de pessoa física são: nome, renda anual e gastos com saúde. 
            Os dados de pessoa jurídica são nome, renda anual e número de funcionários. 
            As regras para cálculo de imposto são as seguintes:
            
            Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. 
            Pessoas com renda de 20000.00 em diante pagam 25% de imposto. 
            Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto.
            Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto fica: (50000 * 25%) - (2000 * 50%) = 11500.00.

            Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. 
            Porém, se a empresa possuir mais de 10 funcionários, ela paga 14% de imposto.
            Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica: 400000 * 14% = 56000.00.

            */

            Console.Write("\n\nEnter the number of tax payers: ");
            int numberOfContributors = int.Parse(Console.ReadLine());

            List<TaxPayer> listTaxPayer = new List<TaxPayer>();

            for (int i = 1; i <= numberOfContributors; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.WriteLine("------------------");

                string taxPayerType;

                while (true)
                {
                    Console.Write("\nIndividual or company (i/c)? ");
                    taxPayerType = Console.ReadLine().Trim().ToUpper();

                    if (taxPayerType == "I" || taxPayerType == "C")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer! Just enter I for Individual or C for Company.");
                    }
                }

                Console.Write("Name: ");
                string taxPayerName = Console.ReadLine();

                Console.Write("Anual income: $ ");
                double taxPayerAnualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (taxPayerType == "I")
                {
                    Console.Write("Health expenditures: $ ");
                    double taxPayerMedicalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listTaxPayer.Add(new Individual(taxPayerName, taxPayerAnualIncome, taxPayerMedicalExpenses));
                }
                else if (taxPayerType == "C")
                {
                    Console.Write("Number of employees: $ ");
                    int taxPayerNumberOfEmployees = int.Parse(Console.ReadLine());

                    listTaxPayer.Add(new Company(taxPayerName, taxPayerAnualIncome, taxPayerNumberOfEmployees));
                }
            }

            Console.WriteLine("\n\n\nTAXES PAID:");
            Console.WriteLine("-----------");

            double totalTaxes = 0.0;

            foreach (TaxPayer taxPayer in listTaxPayer)
            {
                totalTaxes += taxPayer.TaxToPay();
                Console.WriteLine(taxPayer);
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
