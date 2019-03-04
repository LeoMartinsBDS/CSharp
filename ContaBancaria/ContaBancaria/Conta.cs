using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }

        public double Saldo { get; private set; }

        
        public Conta(int nc, string titular) {
            NumeroConta = nc;
            TitularConta = titular;
        }

        public Conta(int nc, string titular, double saldo) : this (nc, titular)
        {
            Depositar(saldo);
        }

        public void Depositar(double valorDeposito) {
            Saldo += valorDeposito;
        }

        public void Sacar(double valorSaque) {
            Saldo -= valorSaque + 5.0;
        }

        public override string ToString()
        {
            return "Dados da conta: " +
                   "Conta " + NumeroConta + ", " +
                   "Titular: " + TitularConta + ", " +
                   "Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
