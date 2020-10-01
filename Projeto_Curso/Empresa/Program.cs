using Empresa.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre deparment´s name: ");
            string depName = Console.ReadLine();
            Console.WriteLine("Enter Worked data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel workLevel = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Deparment deparment = new Deparment(depName);
            Worker worker = new Worker(name, workLevel, salary, deparment);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hour);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Deparment.Name);
            Console.WriteLine("Income for: " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}
