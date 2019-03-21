using ExercicioFixacaoInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoInterface.Services
{
    class ContractProccessmentService
    {
        private IPaymentService _paymentService;

        public ContractProccessmentService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        
        public void proccessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date,fullQuota));
            }
        }
    }
}
