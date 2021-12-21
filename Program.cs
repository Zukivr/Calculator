using System;


namespace ConsoleApp1
{
	internal class Calculator
	{
		static void Main(string[] args)
		{
			// My first basic calculator program by Zuki
			MyCalculator();
		}

		public static void MyCalculator()
		{
			int menu;
			float val1;
			float val2;
			float result;
			string tryAgain;
			float parsed;

			do
			{
				Console.WriteLine("Welcome to the calculator. Please choose an operation to continue, by entering the corresponding number.");
				Console.WriteLine("1: Addition");
				Console.WriteLine("2: Subtraction");
				Console.WriteLine("3: Multiplication");
				Console.WriteLine("4: Division");
				bool menuCheck = int.TryParse(Console.ReadLine(), out menu);
				if (menuCheck == true)
				{
					Console.Clear();

					switch (menu)
					{
						case 1:
							Console.WriteLine("Choose two numbers to add up.");
							bool success = float.TryParse(Console.ReadLine(), out parsed);
							val1 = parsed;
							bool success2 = float.TryParse(Console.ReadLine(), out parsed);
							val2 = parsed;
							if (success && success2)
							{
								result = val1 + val2;
								Console.WriteLine("The result is: " + result);
							}
							else
							{
								Console.WriteLine("The input was incorrect, please try again.");
							}
							break;

						case 2:
							Console.WriteLine("Choose two numbers to subtract.");
							success = float.TryParse(Console.ReadLine(), out parsed);
							val1 = parsed;
							success2 = float.TryParse(Console.ReadLine(), out parsed);
							val2 = parsed;
							if (success && success2)
							{
								result = val1 - val2;
								Console.WriteLine("The result is: " + result);
							}
							else
							{
								Console.WriteLine("The input was incorrect, please try again.");
							}
							break;

						case 3:
							Console.WriteLine("Choose two numbers to multiply.");
							success = float.TryParse(Console.ReadLine(), out parsed);
							val1 = parsed;
							success2 = float.TryParse(Console.ReadLine(), out parsed);
							val2 = parsed;
							if (success && success2)
							{
								result = val1 * val2;
								Console.WriteLine("The result is: " + result);
							}
							else
							{
								Console.WriteLine("The input was incorrect, please try again.");
							}
							break;

						case 4:
							Console.WriteLine("Choose two numbers divide.");
							success = float.TryParse(Console.ReadLine(), out parsed);
							val1 = parsed;
							success2 = float.TryParse(Console.ReadLine(), out parsed);
							val2 = parsed;
							if (success && success2)
							{
								result = val1 / val2;
								Console.WriteLine("The result is: " + result);
							}
							else
							{
								Console.WriteLine("The input was incorrect, please try again.");
							}
							break;

						default:
							Console.WriteLine("An error occured! Please try again.");
							break;
					}
				}
				else
				{
					Console.WriteLine("Your input was wrong.");
				}
				Console.WriteLine("Do you want to try again? (type: yes / no)");
				tryAgain = Console.ReadLine();
				Console.Clear();
			} while (tryAgain == "yes");
		}
	}
}

