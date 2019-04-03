using System;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Quantos funcionários serão registrados?");
            int n = Convert.ToInt32(Console.ReadLine());
            Employee[] vet = new Employee[n];
            for (int i = 0; i<n;i++)
            {
                Console.WriteLine("\nEntre com os dados do funcionário "+(i+1));
                Console.Write("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome: ");
                String name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                list.Insert(i, vet[i] = new Employee(id, name, salary));
                
            }
            Console.WriteLine();
            foreach (Employee obj in list) Console.WriteLine(obj);
            Console.WriteLine("Entre com o id do funcionário que vai aumentar o salário");
            int idm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com a porcentagem a ser aumentada");
            double porcentagem = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if(list.Equals(vet[i].Id == idm))
                {
                    vet[i].IncreaseSalary(porcentagem);
                }
                else
                {
                    Console.WriteLine("Não existe esse id");
                    break;
                }
                
            }
            
        }
    }
}
