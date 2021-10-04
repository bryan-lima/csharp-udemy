using System;
using System.Collections.Generic;
using System.Text;
using FixationExercise.Entities;
using FixationExercise.Interfaces;

namespace FixationExercise.Services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicInstallment = contract.TotalValue / months;

            for (int month = 1; month <= months; month++)
            {
                DateTime installmentDate = contract.Date.AddMonths(month);

                double updatedInstallment = basicInstallment + _onlinePaymentService.Interest(basicInstallment, month);
                double finalValueInstallment = updatedInstallment + _onlinePaymentService.PaymentFee(updatedInstallment);

                contract.AddInstallment(new Installment(installmentDate, finalValueInstallment));
            }
        }
    }
}