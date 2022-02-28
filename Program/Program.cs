using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employe> list = new List<Employe>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Employe(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int ide = int.Parse(Console.ReadLine());

            Employe e = list.Find(x => x.Id == ide);

            if (e != null)
            {
                Console.Write("Enter the porcentage: ");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e.SalaryIncrease(porcentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach (object obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}