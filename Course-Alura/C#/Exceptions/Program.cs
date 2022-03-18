using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // se eu quiser pesquisar no google por exeções no C# msdn exception
            try
            {
                Method();
                CorrentAcount account = new CorrentAcount(2, 10);

                account.ToDeposit(500);
                Console.WriteLine("Your balance is "+ account.getBalance());

                account.ToSend(1400);
                Console.WriteLine("Your balance is " + account.getBalance());

               // account.ToDeposit(10);
              // Console.WriteLine("Your balance is " + account.getBalance());

            }
            catch (DivideByZeroException)// se eu quiser usar outra exception para traramento diferente
            {
                Console.WriteLine("Error by zero");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Something went wrong: "+e.ParamName);  // pegando o nomeof
                Console.WriteLine("Something went wrong!", e.Message);
                Console.WriteLine(e.Message);
            }
            catch (OperaionFinanceException e)// Criei essa exception para tratar o erro ela pode usar dois retornos
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Something went wrong " + e.Message);
               
               
            }
            catch (Exception e)// trata todas as exception
            {
                Console.WriteLine("It isn't to divide for 0!" + e.Message);
                //throw;    esse throw é usando quando meu metodo return alguma coisa
            }

            Console.ReadLine();
        }

        private static void Method()
        {
            TestDivision(2);
        }

        private static void TestDivision(int divisor)
        {
            
                int result = ToDivide(10, divisor);
                Console.WriteLine("Result of division 10 for " + divisor + " is " + result);

        }

        private static int ToDivide(int number, int divisor)
        {

            CorrentAcount acount = null;
            //Console.WriteLine(acount.Balance);

            return number / divisor;
        }
    }

   
}
