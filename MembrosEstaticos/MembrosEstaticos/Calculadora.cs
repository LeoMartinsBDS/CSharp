using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{
    class Calculadora
    {
        //static permite a chamada sem a instancia do objeto
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
