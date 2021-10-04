using System;
using System.Collections.Generic;
using System.Text;
using FixationExercise.Entities;

namespace FixationExercise.Services
{
    public class ContractService
    {
        public void ProcessContract(Contract contract, int months)
        {
            for (int month = 1; month <= months; month++)
            {
                double installmentValue = contract.TotalValue / months;

                double interest = contract.OnlinePaymentService.Interest(installmentValue, month);
                installmentValue += interest * month;

                double paymentFee = contract.OnlinePaymentService.PaymentFee(installmentValue);
                installmentValue += paymentFee;

                DateTime installmentDate = contract.Date.AddMonths(month);

                Installment installment = new Installment(installmentDate, installmentValue);
                contract.Installments.Add(installment);
            }
        }
    }
}