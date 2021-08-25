using System;
using System.Globalization;
using FixationExercise.Entities;
using FixationExercise.Entities.Exceptions;

namespace FixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Fazer um programa para ler os dados de uma conta bancária e depois realizar um saque nesta conta bancária, mostrando o novo saldo.
            Um saque não pode ocorrer ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de saque da conta.
            Implemente a conta bancária conforme projeto abaixo:


                                        +-------------------------------------+
                                        |               Account               |
                                        +-------------------------------------+
                                        | - number: Integer                   |
                                        | - holder: String                    |
                                        | - balance: Double                   |
                                        | - withdrawLimit: Double             |
                                        +-------------------------------------+
                                        | + deposit(amount: Double): void     |
                                        | + withdraw(amount: Double): void    |
                                        +-------------------------------------+

            */

            try
            {
                Console.WriteLine("\nEnter account data:");
                Console.WriteLine("-------------------");

                Console.Write("Number: ");
                int accountNumber = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string accountHolder = Console.ReadLine();

                Console.Write("Initial balance: $ ");
                double accountBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: $ ");
                double accountWithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(accountNumber, accountHolder, accountBalance, accountWithdrawLimit);

                Console.Write("\nEnter amount for withdraw: $ ");
                double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(amountWithdraw);

                Console.WriteLine($"\nNew balance: $ {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"\nWithdraw error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"\nFormat error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nUnexpected error: {e.Message}");
            }
        }
    }
}
