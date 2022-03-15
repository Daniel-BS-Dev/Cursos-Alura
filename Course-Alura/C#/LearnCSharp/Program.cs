using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
	class Program {


		static void Main(string[] args)
		{

			// variaveis
			int number = 1;  // 32 bits
			long number5 = 6; // 64 bits
			double number2 = 2.9;
			float number3 = 1.3f;
			short number4 = 3; // 16 bits
			char name = ' ';
			string name1 = "daniel";
			bool istrue = true;


			// cast
			number = (int)number3;


			// quebra de linhas
			Console.WriteLine(@"
-daniel
-antoniel
-israel");

			Console.WriteLine(number4 + number5);
			Console.WriteLine(15.0 / 2); // divisão com casas decimais
			Console.WriteLine(15 / 2); // divisão sem casas decimais



			for (int i = 0; i <= 10; i++)
			{
				for (int j = 0; j <= 10; j++)
				{
					Console.Write("*");
					if (i == j) {
						break;
					
					}
				}

				Console.WriteLine();

			}


			Console.WriteLine();

			// outra forma diferente de fazer o laço
			for (int i = 0; i <= 10; i++)
			{
				for (int j = 0; j <= i ; j++)
				{
					Console.Write("*");
					
				}

				Console.WriteLine();

			}


			// fatorial
			int fat = 1;
		

			for (int i = 1; i <= 6; i++)
			{
				fat *= i;
				Console.WriteLine(fat);

			}

			





			Console.ReadLine();


		}
	}
}
