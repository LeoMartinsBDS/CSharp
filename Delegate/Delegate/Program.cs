using System;
using Delegate.Services;

namespace Delegate
{
    //declaração do delegate
    delegate void BinaryNumericOperation(double n1, double n2);
    
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //op é uma referencia a função soma
            //multicast delegate
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a,b);
        }
    }
}
