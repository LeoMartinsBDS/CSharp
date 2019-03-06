using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("STRUCT");
            Point p;

            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);

            //se inicializar ele pega o valor padrão
            p = new Point();
            Console.WriteLine(p);

            //variavel declarada mas não instanciada fica como nao atribuida
            //Classe -> variaveis são ponteiros, OO
            //Struct -> variaveis são caixas, perfomático

            //NULLABLE
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("NULLABLE");
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");


            //OPERADOR DE COALESCENCIA NULA
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("COALESCENCIA NULA");

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine("A: "+ a);
            Console.WriteLine("B: "+ b);
        }
    }
}
