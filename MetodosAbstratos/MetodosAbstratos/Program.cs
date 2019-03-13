using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine($"Shape #{x} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(color, radius));
                }

            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
