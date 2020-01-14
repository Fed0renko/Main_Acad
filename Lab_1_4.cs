using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
	// 1) declare enum ComputerType
		enum ComputerType
		{
			Desctop,
			Laptop,
			Server
		}

	// 2) declare struct Computer
		struct Computer
		{
			private int cpu, memory, size;
			private decimal cpu_freq;
			
			// Сnециальный конструктор.
			public void SetComputer (int Comp_CPU, decimal Comp_CPU_Freq, int Comp_Memory, int Comp_Size)
				{
				cpu = Comp_CPU;
				cpu_freq= Comp_CPU_Freq;
				memory = Comp_Memory;
				size = Comp_Size;
				}
			// свойство CPU
			public int CPU
			{
				get { return cpu; }
				set { cpu = value; }
			}

			// свойство CPU_FREQ
			public decimal CPU_FREQ
			{
				get { return cpu_freq; }
				set { cpu_freq = value; }
			}

			// свойство MEMORY
			public int MEMORY
			{
				get { return memory; }
				set { memory = value; }
			}

			// свойство SIZE
			public int SIZE
			{
				get { return size; }
				set { size = value; }
			}
		}
		
		static void Main(string[] args)
        {
	// 3) declare jagged array of computers size 4 (4 departments)
			int[][] array = new int [4][];


	// 4) set the size of every array in jagged array (number of computers)
			/*
			array[0] = new int[3] { 2, 2, 1};
			array[1] = new int[2] { 0, 3}; // как можно задать пустое значение? типа { , 3} -> {0,3}
			array[2] = new int[2] { 3, 2 };
			array[3] = new int[3] { 1, 1, 2 };
			*/
			/*
			array[0] = new int[3];
			array[1] = new int[2];
			array[2] = new int[2];
			array[3] = new int[3];
			
			Console.WriteLine(array.Length);
			Console.ReadKey();
			*/

			/*
			int[,] mas1;
			int[,] mas2 = new int[2, 3];
			int[,] mas3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
			int[,] mas4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
			int[,] mas5 = new [,]{ { 0, 1, 2 }, { 3, 4, 5 } };
			int[,] mas6 = { { 0, 1, 2 }, { 3, 4, 5 } };
			*/


	// 5) initialize array
			// Note: use loops and if-else statements

			#region Вопрос 1 ?
			// Как можно по другому заполнить массив указанными значениями?
			#endregion

			for (int i = 0; i < array.Length; i++) 
			{
				if (i == 0)
				{
					array[i] = new int[3] {2,2,1};
				}else if (i == 1)
				{
					array[i] = new int[2] { 0, 3 };
				}
				else if (i == 2)
				{
					array[i] = new int[2] { 3, 2 };
				}
				else if (i == 3)
				{
					array[i] = new int[3] { 1, 1, 2 };
				}
			}
			
			// Вывести все значения.
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].Length; j++ )
				{
					Console.WriteLine("Значение [{0}] [{1}] = {2}", i, j, array[i][j]);
				}
			}
			Console.ReadKey();

	// 6) count total number of every type of computers

			int numberComputerTypeDesctop = 0;
			int numberComputerTypeLaptop = 0;
			int numberComputerTypeServer = 0;
			
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					if(j == (int)ComputerType.Desctop)
					{
						numberComputerTypeDesctop += array[i][j];
					}
					else if(j == (int)ComputerType.Laptop)
					{
						numberComputerTypeLaptop += array[i][j];
					}
					else if(j == (int)ComputerType.Server)
					{
						numberComputerTypeServer += array[i][j];
					}
				}
			}

			#region Вопрос 2 ?
			// Как можно вывести в Console.WriteLine наименования "Desctop, ...." по другому (через enum ComputerType)?
			#endregion

			Console.WriteLine("Компьютеров типа \"Desctop\" - {0}, типа \"Laptop\" - {1}, типа \"Server\" - {2}", 
				numberComputerTypeDesctop, numberComputerTypeLaptop, numberComputerTypeServer);
			Console.ReadKey();

	// 7) count total number of all computers
			// Note: use loops and if-else statements
			// Note: use the same loop for 6) and 7)

			int numberComputerAll = 0;
			foreach (int[] row in array)
			{
				foreach (int number in row)
				{
					numberComputerAll += number;
				}
			}

			Console.WriteLine("Всего компьютеров = {0} \t\n", numberComputerAll);
			//Console.WriteLine($"{numberComputerAll} \t");
			Console.ReadKey();

	// 8) find computer with the largest storage (HDD) - (найти компьютер с самым большим хранилищем (HDD))
			// compare HHD of every computer between each other; (сравнивать HHD каждого компьютера между собой;)
			// find position of this computer in array (indexes) (найти положение этого компьютера в массиве (индексы))
			// Note: use loops and if-else statements

			//decimal[,] arrayComp;
			//decimal[,] arrayComp = new decimal[3,3];
			//decimal[,] arrayComp = new decimal[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } };

			#region Вопрос 3 ?
			// Как можно использовать структуру для создания и инициализации массива
			/*
			//Пример создания массива через структуру
			//Выделить память для 3 строк
			Computer[][] arrayComp = new Computer[3][];
			//В каждой строке выделить память для 4 экземпляров структур
			for (int i = 0; i < 3; i++)
			{
				arrayComp[i] = new Computer[4];
			}
			//Заполнить поля структур значениями
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 4; j++)
				{
					arrayComp[i][j].CPU = ...
				}
			*/
			#endregion

			decimal[,] arrayComp = new decimal[3, 4] { { 4, 2.5m, 6, 500 }, { 2, 1.7m, 4, 250 }, { 8, 3m, 16, 2 * 1024 } };
			
			/*
			// Вывести все значения.
			for (int i = 0; i < arrayComp.GetLength(0); i++)
			{
				//for (int j = 0; j < arrayComp.Length/arrayComp.GetLength(0); j++) // альтернативное решение )
				for (int j = 0; j < arrayComp.GetLength(1); j++)
				{
					Console.Write("{0,8}", arrayComp[i, j]);
				}
				Console.WriteLine();
			}
			*/
			int maxHDD = 0;
			int indxColumn = -1;
			int indxRow = -1;

			for (int i = 0; i < arrayComp.GetLength(0); i++)
			{
				for (int j = 0; j < arrayComp.GetLength(1); j++)
				{
					if(j == arrayComp.GetLength(1)-1)
					{
						maxHDD = (int)(arrayComp[i, j]);
						indxColumn = i;
						indxRow = j;
						if (arrayComp[i, j] > maxHDD)
						{
							maxHDD = (int)(arrayComp[i, j]);
							indxColumn = i;
							indxRow = j;
						}
					}
				}
			}
			Console.WriteLine();
			Console.WriteLine("Наибольшая память составляет {0} \t\nКомпьютер с индексом [{1},{2}]", maxHDD,indxColumn,indxRow);
			Console.ReadKey();





			// 9) find computer with the lowest productivity (CPU and memory) - (найти компьютер с самой низкой производительностью (процессор и память))
			// compare CPU and memory of every computer between each other; (сравнивать процессор и память каждого компьютера между собой;)
			// find position of this computer in array (indexes) (найти положение этого компьютера в массиве (индексы))
			// Note: use loops and if-else statements
			// Note: use logical oerators in statement conditions

			int lowCPU, lowCPUTemp, indxColumnLow = -1, indxRowLow = -1;
			lowCPU = lowCPUTemp = int.MaxValue;
			decimal lowMemory, lowMemoryTemp;
			lowMemory = lowMemoryTemp = decimal.MaxValue;
			
			for (int i = 0; i < arrayComp.GetLength(0); i++)
			{
				int j = 0;
				for (; j < arrayComp.GetLength(1)-2; j++)
				{
					if (j == 0)
					{
						lowCPUTemp= (int)(arrayComp[i, j]);
					}else
					{
						lowMemoryTemp = (arrayComp[i, j]);
					}
				}
				if(lowCPUTemp < lowCPU && lowMemoryTemp < lowMemory)
				{
					lowCPU = lowCPUTemp;
					lowMemory = lowMemoryTemp;
					indxColumnLow = i;

					#region Вопрос 4 ?
					// Как сделать бе indxRowLow = j-1?
					#endregion
					indxRowLow = j-1;
				}
			}
			Console.WriteLine();
			Console.WriteLine("Компьютер с самой низкой производительностью (процессор и память) {0} - {1} \t\n" +
				"Компьютер с индексами CPU, память [{2},{3}]-[{2},{4}]", lowCPU, lowMemory, indxColumnLow, indxRowLow-1, indxRowLow);
			Console.ReadKey();


			// 10) make desktop upgrade: change memory up to 8 (сделать обновление Desctop: изменить память до 8)
			// change value of memory to 8 for every desktop. Don't do it for other computers (измените значение памяти на 8 для Desctop. Не делать для других компьютеров)
			// Note: use loops and if-else statements

			arrayComp[0, 1] = 8m; // не понятна задача

			// Вывести все значения.
			for (int i = 0; i < arrayComp.GetLength(0); i++)
			{
				//for (int j = 0; j < arrayComp.Length/arrayComp.GetLength(0); j++) // альтернативное решение )
				for (int j = 0; j < arrayComp.GetLength(1); j++)
				{
					Console.Write("{0,8}", arrayComp[i, j]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();

		}

	}
}
