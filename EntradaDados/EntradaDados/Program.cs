using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura");
            string informacoes = Console.ReadLine();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            string[] vet = informacoes.Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
