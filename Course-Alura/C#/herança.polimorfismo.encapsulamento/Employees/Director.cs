using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança.polimorfismo.encapsulamento.Employees
{
    class Director : Employee // director herda de funcionario
    {

        public Director(string name, string cpf, double salary) : base(name, cpf, salary)
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 1.15; // aumento no salario de 15%
        }

        // o metodo começa com letra maiuscula para presenta o get assim eu não preciso criar um no atributo _bonus
        public override double GetBonus()
        {  // minha classe director herdando o meu metodo
            return Salary *  1.5; // base é com a palavra super do java para minha classe filha herdar algo da minha classe pai eu priciso usar o base
        }
    }
}
