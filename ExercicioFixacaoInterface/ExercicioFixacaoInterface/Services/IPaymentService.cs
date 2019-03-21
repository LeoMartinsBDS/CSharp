using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoInterface.Services
{
    interface IPaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
