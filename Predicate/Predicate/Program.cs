using Predicate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //delegate para referencia a uma função
            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(func).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");

            //action
            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(act);
            foreach (Product prod in list)
            {
                Console.WriteLine(prod);
            }

            Console.WriteLine("Removido");
            list.RemoveAll(ProductTeste);

            foreach (Product prod in list)
            {
                Console.WriteLine(prod);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        //PREDICATE
        public static bool ProductTeste(Product p)
        {
            return p.Price >= 100;
        }

    }
}
