using ExercicioFixacaoMetodoAbstrato.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoMetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    persons.Add(new PhysicalPerson(name, anualIncome, healthExpenditures));
                }
                else {
                    Console.Write("Number of employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine());

                    persons.Add(new LegalPerson(name, anualIncome, numberEmployee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double totalTaxes = 0.0;
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name + ": $ " + person.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += person.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
