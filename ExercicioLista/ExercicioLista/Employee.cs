using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioLista
{
    class Employee
    {
        public int Id { get; private set; }
        public double Salary { get; private set; }
        public String Name { get; private set; }
        

        public Employee(int id,String name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
       
        }
        public Employee()
        {

        }

        public void IncreaseSalary(double q)
        {
            this.Salary = this.Salary + (this.Salary * q) / 100;
        }
        public override string ToString()
        {
            return "Id: "+this.Id+"; Name: "+this.Name+"; Salary: "+this.Salary;
        }
    }
}
