using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = { 21, 65, 43, 1, 54, 2, 76, 3, 4, 5, 6, 7 };

            List<string> name = new List<string>();
            name.Add("Daniel");
            name.Add("Pedro");
            name.Add("Fernando");
            name.Add("Fernando");

            Array.Sort(number);

            foreach(int v in number)
            {
                Console.Write(v +" ");
            }

            foreach (string l in name)
            {
                Console.Write(l + " ");
            }

            Console.WriteLine(name.Count);
            Console.WriteLine(name.Exists(e => e == "Daniel"));
            Console.WriteLine(name.Exists(e => e.IndexOf("Dani") == -1)); // buscando por parte a string. -1 e true



            Console.ReadLine();
        }
    }
}
