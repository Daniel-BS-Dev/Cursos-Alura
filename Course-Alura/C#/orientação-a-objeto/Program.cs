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

            AcountCorrent acount = new AcountCorrent();
            acount.Saldo= 100;

            Client person = new Client("Pedro", 11111);

            acount.Titular = person;

            Console.WriteLine(acount.Saldo);


            Console.WriteLine(acount.Titular.Name);
            Console.WriteLine(acount.Titular.Code);
            Console.WriteLine(AcountCorrent.TotalDeContasCriadas);





            Console.ReadLine();
        }
    }
}
