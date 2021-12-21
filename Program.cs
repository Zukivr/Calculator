using System;


namespace ConsoleApp1
{
	internal class Calculator
	{
		static void Main(string[] args)
		{
			// My first basic calculator program by Zuki
			/*
			 * Problems to figure out: how to check if input really is a number and add a if conditon to avoid crashes?
			 *
			 */
			Mycalculator();

		}


		public static void Mycalculator()
		{


			int menu;
			float val1;
			float val2;
			float result;
			string tryagain;






			do
			{
				Console.WriteLine("Welcome to the calculator. Please choose an operation to continue, by entering the corresponding number.");
				Console.WriteLine("1: Addition");
				Console.WriteLine("2: Subtraction");
				Console.WriteLine("3: Multiplication");
				Console.WriteLine("4: Division");


				menu = Convert.ToInt32(Console.ReadLine());

				Console.Clear();

				switch (menu)
				{
					case 1:
						
						Console.WriteLine("Choose two numbers to add up.");
						val1 = float.Parse(Console.ReadLine());
						val2 = float.Parse(Console.ReadLine());
						result = val1 + val2;
						Console.WriteLine("The result is: " + result);
						break;


					case 2:
						
						Console.WriteLine("Choose two numbers to subtract.");
						val1 = float.Parse(Console.ReadLine());
						val2 = float.Parse(Console.ReadLine());
						result = val1 - val2;
						Console.WriteLine("The result is: " + result);
						break;


					case 3:
					
						Console.WriteLine("Choose two numbers to multiply.");
						val1 = float.Parse(Console.ReadLine());
						val2 = float.Parse(Console.ReadLine());
						result = val1 * val2;
						Console.WriteLine("The result is: " + result);
						break;


					case 4:
						
						Console.WriteLine("Choose two numbers divide.");
						val1 = float.Parse(Console.ReadLine());
						val2 = float.Parse(Console.ReadLine());
						result = val1 / val2;
						Console.WriteLine("The result is: " + result);
						break;


					default:
						
						Console.WriteLine("An error occured! Please try again.");
						break;


				}
				Console.WriteLine("Do you want to try again? (yes/no)");
				tryagain = Console.ReadLine();
				Console.Clear();
			} while (tryagain == "yes");
		}
	}


}

