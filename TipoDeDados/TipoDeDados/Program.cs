using System;

namespace TipoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados básicos

            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            //recomendação colocar L no final

            bool completo = false;
            char genero = 'F';
            //char é sempre aspas simples. Representando caracter
            //pode utilizar o código UNICODE do caracter
            char letra = '\u0041';

            float n5 = 4.5F;
            //sempre colocar o F. Se não tiver vai achar que é double
            double n6 = 4.5;
            //o C# segue o padrão do computador, se tiver portugues é usado ','
            string nome = "Leonardo Martins";

            object obj1 = "Mano Brown";
            //tipo object é genérico, aceita qualquer coisa
            object obj2 = 4.5F;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

        }
    }
}
