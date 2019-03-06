using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int x = 0; x < n; x++)
            {
                Console.WriteLine("Digite sua altura: ");
                vect[x] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
