using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
		enum Operation // по умолчанию System.Int32 но можно определять
					   //enum Operation : byte
		{
			Multiplication = 1,
			Divide,// = 2,
			Addition,// = 3,
			Subtraction,// = 4,
			Exponentiation// =5
		}
		/*
		enum Operation1
		{
			Multiplication = 1,
			Divide,// = 2,
			Addition,// = 3,
			Subtraction,// = 4,
			Exponentiation// =5
		}
		*/
		static void Main(string[] args)
        {
            long a;
            Console.WriteLine(
	@"Please,  type the number:
	1. Farmer, wolf, goat and cabbage puzzle
	2. Console calculator
	3. Factirial calculation
	(Пожалуйста, введите номер: 
	1. Головоломка: фермер, волк, коза и капусты 
	2. Консольный калькулятор 
	3. Расчет факториала)
	");
            
            a = long.Parse(Console.ReadLine());
			switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit (Выход)");
                    break;
            }
            Console.WriteLine("Press any key (Нажмите любую клавишу)");
            Console.ReadLine();
        }
		#region farmer
		static void Farmer_puzzle()
		{
			//Key sequence: 3817283 or 3827183
			// Declare 7 int variables for the input numbers and other variables
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?
(Из одного берега на другой следует перевезти волка, козу и капусту.
В то же время нельзя нести и оставлять вместе на берегах волка и козу,
козу и капусту. Можно перевозить только волка с капустой или каждого пассажира отдельно.
Вы можете делать сколько угодно рейсов. Как перевезти волка, козу и капусту, чтобы все прошло хорошо?)
");
			Console.WriteLine("There: farmer and wolf - 1 (На другую сторону: фермер и волк - 1)");
			Console.WriteLine("There: farmer and cabbage - 2 (На другую сторону: фермер и капуста - 2)");
			Console.WriteLine("There: farmer and goat - 3 (На другую сторону: фермер и козел - 3)");
			Console.WriteLine("There: farmer  - 4 (На другую сторону: фермер - 4)");
			Console.WriteLine("Back: farmer and wolf - 5 (Обратно: фермер и волк - 5)");
			Console.WriteLine("Back: farmer and cabbage - 6 (Обратно: фермер и капуста - 6)");
			Console.WriteLine("Back: farmer and goat - 7 (Обратно: фермер и козел - 7)");
			Console.WriteLine("Back: farmer  - 8 (Обратно: фермер - 8)");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Please,  type numbers by step (Пожалуйста, наберите номера шаг за шагом)");
			// Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing
			int i1, i2, i3, i4, i5, i6, i7;
			bool b = false;
			do
			{
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Введите цифру 1-го шага: \r");
				i1 = int.Parse(Console.ReadLine());
				Console.WriteLine("Введите цифру 2-го шага: \r");
				i2 = int.Parse(Console.ReadLine());
				Console.WriteLine("Введите цифру 3-го шага: \r");
				i3 = int.Parse(Console.ReadLine());
				Console.WriteLine("Введите цифру 4-го шага: \r");
				i4 = int.Parse(Console.ReadLine());
				Console.WriteLine("Введите цифру 5-го шага: \r");
				i5 = int.Parse(Console.ReadLine());
				Console.WriteLine("Введите цифру 6-го шага: \r");
				i6 = int.Parse(Console.ReadLine());
				Console.WriteLine("Введите цифру 7-го шага: \r");
				i7 = int.Parse(Console.ReadLine());

				if (i1 == 3 && i2 == 8 && (i3 == 1 || i3 == 2) && i4 == 7 && (i5 == 2 || i5 == 1) && i6 == 8 && i7 == 3)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine();
					Console.WriteLine("Позравляем, Вы дали правильный ответ !!! \n\r");
					b = true;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine();
					Console.WriteLine("Try again :( \r");
					b = false;
				}
			} while (b == false);
		}
        #endregion

        #region calculator
        static void Calculator()
        {
			// Set Console.ForegroundColor  value
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication (Умножение)
2. Divide (Деление)
3. Addition (Сложение)
4. Subtraction (Вычитание)
5. Exponentiation (Возведение в степень) ");
			// Implement option input (1,2,3,4,5)
			//     and input of  two or one numbers
			//  Perform calculations and output the result 
			double num1, num2, result;
			result = 0.0;

			//Console.WriteLine("Type = {0}", Enum.GetUnderlyingType(typeof(Operation)));
			
			Operation numOper = (Operation)Enum.Parse (typeof(Operation), Console.ReadLine()); // не совсем понятная конструкция

			//Console.WriteLine("numOper = {0}", (int)numOper);

			Console.WriteLine("Введите первое число: \r");
			num1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите второе число: \r");
			num2 = double.Parse(Console.ReadLine());

			
			switch (numOper)
			{
				case Operation.Multiplication: // почему не могу использовать числовой номер операции 1,2,3,4,5
					result = num1 * num2;
					break;
				case Operation.Divide:
					result = num1 / num2;
					break;
				case Operation.Addition:
					result = num1 + num2;
					break;
				case Operation.Subtraction:
					result = num1 - num2;
					break;
				case Operation.Exponentiation:
					result = Math.Exp(num1);
					break;
			}
			
			
			// Получить все пары "имя-значение"
			//var op = new Operation1();
			var op = new Operation();
			Array mas = Enum.GetValues(op.GetType());

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("This enum has {0} members. ", mas.Length);
			// Вывести строковое имя и ассоциированное значение ,
			// используя флаг формата D
			for (int i = 0; i < mas.Length ; i++)
			{
				Console.WriteLine(" Name : {0} , Value : {0:D} ", mas.GetValue(i)); // D или d Используется для форматирования десятичных чисел . 
																					//В этом флаге можно также указывать минимальное количество цифр для nредставления значения
			}

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Результат операции \"{0}\" равен {1} \r", numOper, result);
		}
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
			// Implement input of the number
			// Implement input the for circle to calculate factorial of the number
			// Output the result
			long n, result;
			result = 1;
			Console.WriteLine("Введите число: \r");
			n = long.Parse(Console.ReadLine());
			for(int i = 2 ; i <= n; i++)
			{
				result = result * i;
			}

			Console.WriteLine("Результат: факториал числа {0} равен {1} \r", n, result);
		}
        #endregion
    }
}
