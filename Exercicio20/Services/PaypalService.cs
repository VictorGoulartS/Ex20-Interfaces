using System;
using Exercicio20.Services;

namespace Exercicio20.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            return amount * months * 0.01;
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
