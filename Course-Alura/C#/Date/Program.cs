using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 2, 7); // data do fim de pagamento
            DateTime dateNow = DateTime.Now;
            TimeSpan difference = dateNow - date;

            TimeSpan diference = TimeSpan.FromMinutes(40);

            string message = "Vencimento em "+ TimeSpanHumanizeExtensions.Humanize(difference);
           

            Console.WriteLine(date);
            Console.WriteLine(dateNow);
            Console.WriteLine(message);
            Console.WriteLine(diference);



            Console.ReadLine();
        }

       
    }
}
