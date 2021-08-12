using System;
using System.Globalization;

namespace section5.exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta.
            
            Este valor de depósito inicial, entretanto, é opcional, ou seja:
                - se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
            
            Importante:
                - uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado.
            
            Já o nome do titular pode ser alterado(pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).
            
            Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso.

            O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $ 5.00.
            
            Nota: 
                - a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e / ou pagar a taxa.

            Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial.

            Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.

            */
            
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|              BANCO LIMA              |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("+--------------------------------------+");

            Console.WriteLine("\n           ABERTURA DE CONTA");
            Console.WriteLine("----------------------------------------");

            Account account;

            Console.Write("\nInfore o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o nome do titular: ");
            string fullName = Console.ReadLine();

            bool hasDnitialDeposit = false;

            while (true)
            {
                Console.Write("\n\nHaverá depósito inicial? (S/N): ");
                string initialDepositAnswer = Console.ReadLine();

                if (initialDepositAnswer.Trim().ToUpper() == "S")
                {
                    hasDnitialDeposit = true;
                    break;
                }
                else if (initialDepositAnswer.Trim().ToUpper() == "N") {
                    break;
                }

                Console.WriteLine("Opção inválida! Informe apenas S para SIM ou N para NÃO.");
            }

            if (hasDnitialDeposit)
            {
                Console.Write("\nInforme o valor do depósito inicial: R$ ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                 account = new Account(accountNumber, fullName, initialDeposit);
            }
            else
            {
                account = new Account(accountNumber, fullName);
            }

            Console.WriteLine("\n\n>>> Dados da conta:");
            Console.WriteLine("\n" + account.DisplayAccountData());

            Console.Write("\nEntre com o valor de depósito: R$ ");
            double depositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            account.Deposit(depositValue);

            Console.WriteLine("\n\n>>> Dados da conta atualizados:");
            Console.WriteLine("\n" + account.DisplayAccountData());

            Console.Write("\nEntre com o valor de saque: R$ ");
            double withdrawalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            account.Withdraw(withdrawalValue);

            Console.WriteLine("\n\n>>> Dados da conta atualizados:");
            Console.WriteLine("\n" + account.DisplayAccountData());
        }
    }
}
