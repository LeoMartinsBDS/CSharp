using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            //É IGNORADO PELA VALIDAÇÃO
            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.QuantidadeEstoque);

        }
    }
}
