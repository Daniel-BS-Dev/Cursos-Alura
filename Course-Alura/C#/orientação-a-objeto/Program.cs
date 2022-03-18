using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientação_a_objeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Client person = new Client("Pedro", 11111);
            AcountCorrent acount = new AcountCorrent(22222, person, 123445, 500);
            acount.Saldo= 100;


            acount.Titular = person;



            Console.WriteLine(acount);
            Console.WriteLine(acount.Saldo);


            Console.WriteLine(acount.Titular.Name);
            Console.WriteLine(acount.Titular.Code);
            Console.WriteLine(AcountCorrent.TotalDeContasCriadas);  // chamando o  atributo total de conta





            Console.ReadLine();
        }
    }
}
