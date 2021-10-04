using System;
using System.Collections.Generic;
using System.Text;
using FixationExercise.Services;
using FixationExercise.Interfaces;
using System.Globalization;

namespace FixationExercise.Entities
{
    public class Contract
    {
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; } = new List<Installment>();

        public IOnlinePaymentService OnlinePaymentService;

        private ContractService _contractService = new ContractService();

        public Contract()
        {
        }

        public Contract(int number, DateTime date, double totalValue, int installments, IOnlinePaymentService onlinePaymentService)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            OnlinePaymentService = onlinePaymentService;
            _contractService.ProcessContract(this, installments);
        }

        public void DisplayInstallments()
        {
            foreach (Installment installment in Installments)
            {
                Console.WriteLine($"{installment.DueDate.ToString("dd/MM/yyyy")} - $ {installment.Amount.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}