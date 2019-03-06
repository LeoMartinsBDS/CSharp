using System;
using System.Globalization;

namespace ProdutosVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            //vetor de produtos
            Product[] products = new Product[n];

            //nulo é valor padrao para TIPO REFERENCIA

            for (int x = 0; x < n; x++) {
                Console.WriteLine("Digite o nome do produto: ");
                string name = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products[x] = new Product
                {
                    Name = name,
                    Price = price
                }; 
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += products[i].Price;
            }

            double precoMedio = 0.0;

            precoMedio = sum / n;

            Console.WriteLine("Preço médio: " + precoMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
