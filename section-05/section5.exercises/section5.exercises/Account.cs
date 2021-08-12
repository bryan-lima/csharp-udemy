using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace section5.exercises
{
    class Account
    {
        public Account(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
        }

        public Account(int accountNumber, string name, double initialDeposit) : this(accountNumber, name)
        {
            AccountNumber = accountNumber;
            Name = name;
            InitialDeposit = initialDeposit;
            Deposit(InitialDeposit);
        }

        public int AccountNumber { get; private set; }

        public string Name { get; set; }

        public double InitialDeposit { get; }

        public double Balance { get; private set; }

        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;
        }

        public void Withdraw(double withdrawalAmount)
        {
            Balance -= withdrawalAmount + 5.0;
        }

        public string DisplayAccountData()
        {
            return "Conta: " + AccountNumber 
                   + "\nTitular: " + Name
                   + "\nSaldo: R$ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
