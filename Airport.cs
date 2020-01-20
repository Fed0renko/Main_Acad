using System;
using System.Text;

namespace ConsoleApp_Airport
{
	class Program
	{
		enum InputInfo
		{
			номеру = 1,
			времени,
			порту
		}

		enum type
		{
			s = 1, // string
			i, // int
			d // datetime
		}

		enum Status
		{
			регистрация,
			ворота_закрыты,
			прибыл,
			вылетел,
			неизвестен,
			отменен,
			ожидается_в,
			задерживается,
			в_полете
		}

		struct PanelInfo
		{
			// № рейса, дата прибытия, дата отправления, время прибытия, время отправления, город, порт прибытия, порт отправления, 
			// авиакомпания, терминал, статус рейса, ворота
			int numbflight;     // № рейса
			DateTime datein;    // дата прибытия
			DateTime dateout;   // дата отправления
			DateTime timein;    // время прибытия
			DateTime timeout;   // время отправления
			string city;        // город
			string portin;      // порт прибытия
			string portout;     // порт отправления
		}

		static void Main(string[] args)
		{
			int n;
			inputData(out n);
			arrayData();
			//randomString(5);
			printToDisplay(randomStr(10));
			printToDisplay(randomInt(1000));
			printToDisplay(randomDate(20).ToShortDateString());
			

		}

		static void inputData(out int number)
		{
			object o;
			bool b = false;
			do
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Выбирите вариант для поиска по: {0}-{1}, {2}-{3}, {4}-{5}",
								(int)InputInfo.номеру, InputInfo.номеру, (int)InputInfo.времени, InputInfo.времени, (int)InputInfo.порту, InputInfo.порту);

				string str = Console.ReadLine();

				if (Enum.TryParse(typeof(InputInfo), str, out o))
				{
					InputInfo inputNumber = (InputInfo)Enum.Parse(typeof(InputInfo), str);
					if (inputNumber == InputInfo.номеру | inputNumber == InputInfo.времени | inputNumber == InputInfo.порту)
					{
						number = (int)inputNumber;
						b = true;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Ведите корректное значение \r");
						Console.ForegroundColor = ConsoleColor.White;
						number = 0;
						b = false;
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Ведите корректное значение \r");
					Console.ForegroundColor = ConsoleColor.White;
					number = 0;
				}

			} while (b == false);

			Console.WriteLine("Выбран вариант: {0} - поиск по {1}", number, o);
			//Console.WriteLine("Value of a: {0}", a);
			Console.ReadKey();

		}

		static void arrayData()
		{
			// № рейса, дата прибытия, дата отправления, время прибытия, время отправления, город, порт прибытия, порт отправления, 
			// авиакомпания, терминал, статус рейса, ворота
			/*
			int numTrip, numPortIn, numPortOut, terminal, gate;
			DateTime dateIn, dateOut, timeIn, timeOut;
			string city, company, status;
			StringBuilder sb = new StringBuilder();
			Random r = new Random();
			*/

			object[,] array = new object[4, 12];
			object[] arrayData = new object[4];

			int rows = array.GetUpperBound(0) + 1;
			int rows1 = arrayData.GetUpperBound(0) + 1;


			for (int i = 0; i < rows; i++)
			{

				arrayData[i] = (randomInt(10), randomDate(10).ToShortDateString(), randomDate(20).ToShortDateString(),
						randomDate(10).ToShortTimeString(), randomDate(20).ToShortTimeString(),
						randomStr(6), randomInt(10), randomInt(10), randomStr(5), randomInt(5),
						Enum.GetName(typeof(Status), randomInt(Enum.GetNames(typeof(Status)).Length)), randomInt(10));
				
			}


			/*

			int rows = array.GetUpperBound(0) + 1;
			int columns = array.Length / rows;
			// или так
			// int columns = mas.GetUpperBound(1) + 1;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					array[i, j] = (randomInt(10),randomDate(20).ToShortDateString(), randomDate(20).ToShortDateString(), 
						randomDate(20).ToShortTimeString(), randomDate(20).ToShortTimeString(),
						randomStr(6), randomInt(10), randomInt(10), randomStr(5), randomInt(5), 
						Enum.GetName(typeof(Status), randomInt(Enum.GetNames(typeof(Status)).Length)), randomInt(10));
				}
			} 
			
			int rows = array.GetUpperBound(0) + 1;
			int columns = array.Length / rows;
			// или так
			// int columns = mas.GetUpperBound(1) + 1;
			*/
			/*
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write($"{array[i, j]} \t");
				}
				Console.WriteLine("\r\t");
			}
			Console.ReadKey();
			*/

			for (int i = 0; i < rows1; i++)
			{
				
				Console.Write($"{arrayData[i]} \t");
				
			}
			Console.ReadKey();

		}

		// Генерация случайной строки
		static string randomStr(int size)
		{
			char[] russian = {  'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У',
				'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к',
				'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
			Random random = new Random();
			string str = "";

			for (int i = 0; i < size; i++)
			{
				str += russian[random.Next(0, russian.Length)];
			}
			return str;
		}

		// Генерация случайного значения int
		static int randomInt(int numEnd)
		{
			Random random = new Random();
			return random.Next(0, numEnd);
		}

		// Генерация случайной даты
		static DateTime randomDate(int numDay)
		{
			Random random = new Random();
			DateTime date = DateTime.Now;
			return date.AddDays(random.Next(0, numDay));
		}

		// Вывод на экран
		static void printToDisplay (object o)
		{
			Console.WriteLine(o);
			Console.ReadKey();
		}
		

	}
}
