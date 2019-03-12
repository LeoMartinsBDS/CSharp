using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            //CASTING DA SUBCLASSE PARA SUPERCLASSE
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING
            //OPERAÇÃO INSEGURA
            //CASTING DA SUPERCLASSE PARA SUBCLASSE
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;//sintaxe alternativa para casting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingAccount) {
                //SavingAccount acc5 = (SavingAccount)acc3;
                SavingAccount acc5 = acc3 as SavingAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            Account acc6 = new Account(1006, "Joao", 500.0);
            Account acc7 = new SavingAccount(1007, "Nana", 500, 0.01);

            acc6.Withdraw(10);
            acc7.Withdraw(10);

            Console.WriteLine(acc6.Balance);
            Console.WriteLine(acc7.Balance);
        }
    }
}
