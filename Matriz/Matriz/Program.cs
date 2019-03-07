using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int x = 0; x < n; x++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int y = 0; y < n; y++) {
                    mat[x, y] = int.Parse(values[y]);
                }
            }


            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negatives numbers: " + count);
            Console.WriteLine();
        }
    }
}
