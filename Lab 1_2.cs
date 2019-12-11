using System;

namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
			// Use "Debugging" and "Watch" to study variables and constants

			//1) declare variables of all simple types:
			//bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
			// their names should be: 
			//boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
			// initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
			// Check results (types and values). Is possible to do initialization?
			// Fix compilation errors (change values for impossible initialization)
			
			bool boo = true;
			char ch = 'S';
			byte b = 8;
			sbyte sb = 8;
			short sh = 10000;
			ushort ush = 300;
			int i = -2147483648;
			uint ui = 3147483648;
			long l = 9223372036854775807;
			ulong ul = 0;
			decimal de = 100000.23232999999m;
			float fl = 1000.65454f;
			double d0 = 20.5;

			Console.WriteLine("VAR = {0}", bool.FalseString);
			Console.WriteLine("VAR = {0}", ++l);
			Console.WriteLine("VAR_Float = {0}", fl);
			Console.WriteLine("VAR_Decimal = {0}", de);
			Console.ReadKey();
			
			//2) declare constants of int and double. Try to change their values.

			
			const int iconst = 1;
			iconst = 2;
			Console.WriteLine("VAR = {0}", iconst);
			Console.ReadKey();
			

			//3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
			// Try to reinitialize by 20.5 and 20 (change values). What results are there?
			
			var a = 20;
			var b = 20.5;

			a = 20.5;
			b = 20;
			
			// 4) declare variables of System.Int32 and System.Double.
			// Initialize them by values of i and d0. Is it possible?
			
			System.Int32 i;
			System.Double d0;
			

			if (true)
            {
				// 5) declare variables of int, char, double 
				// with names i, ch, do
				// is it possible?
				
				int i;
				char ch;
				double d0;
				
				// 6) change values of variables from 1)
				
				i = i;
				ch = ch;
				d0 = d0;
				
            }

			// 7)check values of variables from 1). Are they changed? Think, why

			Console.Clear();
			Console.WriteLine("Var from 1) = {0}", i);
			Console.ReadKey();

			// 8) use implicit/ explicit conversion to convert variables from 1). 
			// Is it possible? 

			i = b;
			ch = i;
			sh = boo;
			l = d0;
			ch = fl;

			ch = (int) i;
			d0 = (decimal) de;
			b = (uint) ui;
			sb = (ulong)ul;

			Console.Clear();
			Console.WriteLine("Var from 1) = {0}", i);
			Console.ReadKey();

			// Fix compilation errors (in case of impossible conversion commemt that line).
			// int -> char
			//Error CS0266  Cannot implicitly convert type 'int' to 'char'.An explicit conversion exists (are you missing a cast?)

			// bool -> short
			//Error CS0029  Cannot implicitly convert type 'bool' to 'short'

			// double -> long
			//Error CS0266  Cannot implicitly convert type 'double' to 'long'.An explicit conversion exists (are you missing a cast?)

			// float -> char 
			//Error CS0266  Cannot implicitly convert type 'float' to 'char'.An explicit conversion exists (are you missing a cast?)

			// int to char
			//Error CS0266  Cannot implicitly convert type 'int' to 'char'.An explicit conversion exists (are you missing a cast?)

			// decimal -> double
			//Error CS0266  Cannot implicitly convert type 'decimal' to 'double'.An explicit conversion exists (are you missing a cast?)

			// byte -> uint
			//Error CS0266  Cannot implicitly convert type 'uint' to 'byte'.An explicit conversion exists (are you missing a cast?)

			// ulong -> sbyte
			//Error CS0266  Cannot implicitly convert type 'ulong' to 'sbyte'.An explicit conversion exists (are you missing a cast?)


			// 9) and reverse conversion with fixing compilation errors.

			i = ch;
			boo = sh;
			//Error CS0029  Cannot implicitly convert type 'short' to 'bool'

			d0 = l;
			fl = ch;

			i = (int)ch;
			de = (decimal)d0;
			ui = (uint )b;
			ul = (ulong)sb;

			// 10) declare int nullable value. Initialize it with 'null'. 
			// Try to initialize variable i with 'null'. Is it possible?

			Nullable<int> inull_1;
			inull_1 = null;   // or Nullable<int> inull_1 = null;

			int? inull_2;
			inull_2 = null;

			i = null;

		}
	}
}
