using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using herança.polimorfismo.encapsulamento.Employees; // import na minha classe employee. Atalho 'control .'

namespace herança.polimorfismo.encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        { 

            ServidorBonus ser = new ServidorBonus();
            Director dir = new Director("Roberta", "1234567", 6000);

            ser.TotalBonus(dir);

       
            dir.IncreaseSalary();

            Console.WriteLine("Salario com aumento Director " + dir.Salary);

            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.GetBonus());
            
            Console.WriteLine("Total de Bonificação: " + ser.GetTotalBonus());
            Console.WriteLine("Total de Funcionario: " + Employee.TotalEmployee);



            Console.ReadLine();
        }
    }
}
