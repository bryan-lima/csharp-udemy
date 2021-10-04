using System;
using System.Collections.Generic;
using System.Text;
using FixationExercise.Interfaces;

namespace FixationExercise.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double PAYMENT_FEE = 0.02;
        private const double TAX_INTEREST = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * PAYMENT_FEE;
        }

        public double Interest(double amount, int months)
        {
            return amount * TAX_INTEREST * months;
        }
    }
}