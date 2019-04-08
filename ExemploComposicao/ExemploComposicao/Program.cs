using System;
using ExemploComposicao.Entities;
using ExemploComposicao.Entities.Enums;

namespace ExemploComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name");
            String deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter with the level of the worker");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, salary, dept);
            Console.WriteLine("Hoe many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hour)" );
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine("Enter  month and year to calculate income (DD/MM/YYYY): ");
            String mey = Console.ReadLine();
            int month = int.Parse(mey.Substring(0,2));
            int year = int.Parse(mey.Substring(3));
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: "+worker.Department.Name);
            Console.WriteLine("Income for " + mey + ": " + worker.Income(year,month));
        }
    }
}
