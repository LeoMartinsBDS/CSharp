using ControleSalario.Entities;
using ControleSalario.Entities.Enums;
using System;
using System.Globalization;

namespace ControleSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);

            Worker worker = new Worker(name, workerLevel, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++) {
                //interpolação
                Console.WriteLine($"Enter #{x} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            Console.Write("Enter month and year ti calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine($"Income for {monthAndYear}: " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
