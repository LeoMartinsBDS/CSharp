using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {

            //PARA USAR O REF É NECESSARIO QUE SEJA INICIADA
            // PARA USAR O OUT ELE NAO É NECESSARIO TER SIDO INICIADO
            //CODE SMELLS, DEVEM SER EVITADOS

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
