using ExFixLinq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExFixLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine();

            Console.Write("Enter the salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] datas = line.Split(",");

                    string name = datas[0];
                    string email = datas[1];
                    double employeeSalary = double.Parse(datas[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, employeeSalary));
                }
            }

            Console.WriteLine("Email of people whose salary is more than 2000.00: ");
            var salaries = employees.Where(e => e.Salary > 2000.00).OrderBy(e => e.Email).Select(e => e.Email);

            foreach (string s in salaries) {
                Console.WriteLine(s);
            }

            var sumSalary = employees.Where(e => e.Name.StartsWith('M')).Sum(e => e.Salary);
            Console.Write("Sum of salary of people whose name starts with 'M': " + sumSalary.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
