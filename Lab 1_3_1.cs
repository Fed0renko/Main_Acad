using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 200;

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            int Guess_number = random.Next(MyMax) + 1;
			// implement input of number and comparison result message in the while circle with  comparison condition

			int userNumb = new int();
			
			do
			{
				Console.Clear();
				Console.WriteLine("Введите число:");
				//Console.ReadKey();
				string str = Console.ReadLine();
				if (!Int32.TryParse(str, out userNumb))
				{
					Console.WriteLine("Вы ввели не целое число");
					Console.ReadKey();
					break;
				}

				if (userNumb <= MyMax)
				{
					Console.WriteLine("Ваше число {0} <= задуманного {1}", userNumb,MyMax);
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Ваше число {0} > задуманного {1}. \nGame OVER!", userNumb, MyMax);
					Console.ReadKey();
				}
			}
			while (userNumb <= MyMax);

			
			
        }
    }
}
