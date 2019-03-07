using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Leo");
            lista.Add("Maria");
            lista.Add("Bob");
            lista.Add("João");
            lista.Add("Ana");
            lista.Insert(2, "Marco");

            foreach (string s in lista) {
                Console.WriteLine(s);
            }

            Console.WriteLine("QTD itens: "+ lista.Count);

            //expressão lambda
            string s1 = lista.Find(x => x[0] == 'L');

            string s2 = lista.FindLast(x => x[0] == 'A');

            Console.WriteLine("First 'L': " + s1);

            Console.WriteLine("Last 'A': " + s2);

            int p1 = lista.FindIndex(x => x[0] == 'L');

            int p2 = lista.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("First position 'L': " + p1);

            Console.WriteLine("First position 'A': " + p2);

            List<string> list2 = lista.FindAll(x => x.Length == 5);

            foreach (string str in list2) {
                Console.WriteLine(str);
            }

            lista.Remove("João");
            Console.WriteLine("------------------------------------");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }

            lista.RemoveAt(3);
            Console.WriteLine("------------------------------------");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }

            lista.RemoveRange(2, 2);
            Console.WriteLine("------------------------------------");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }

            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------------------------");
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }

           
        }
    }
}
