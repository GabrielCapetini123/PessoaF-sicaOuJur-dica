using System;
using System.Collections.Generic;
using ExercícioPJ.Entities;
using System.Globalization;


namespace ExercícioPJ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPlayer> list = new List<TaxPlayer>();

            Console.Write("Enter the number of tax player: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Player #{i} data: ");
                Console.Write("Individual or Company (i/c) ? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healthExpenditures));
                }

                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numberOfEmployees));
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAKES PAID: ");

            foreach (TaxPlayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES : $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

