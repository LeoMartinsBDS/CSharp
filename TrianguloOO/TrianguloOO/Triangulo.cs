using System;

namespace TrianguloOO
{
    class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        

        public double calcularArea(double A, double B, double C)
        {
            double p = (A + B + C) / 2.0;

            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }

    }

}
