using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança.polimorfismo.encapsulamento.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployee { get; private set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string cpf, double salary)
        {
            Name = name;
            CPF = cpf;
            Salary = salary;
            TotalEmployee++;
         
        }

        public abstract void IncreaseSalary();
        public abstract double GetBonus(); // o metodo começa com letra maiuscula para presenta o get assim eu não preciso criar um no atributo _bonus
       
    }
}
