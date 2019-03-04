using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta; 

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n): ");
            char temDeposito = char.Parse(Console.ReadLine());

            if (temDeposito.Equals('s') || temDeposito.Equals('S'))
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numeroConta, titularConta, saldo);

                Console.WriteLine(conta);
            }
            else {
                conta = new Conta(numeroConta, titularConta);

                Console.WriteLine(conta);
            }
            
            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Sacar(valorSaque);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
            
        }
    }
}
