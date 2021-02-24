using System;

namespace helloinseverallanguages
{
	class program
	{
		public static void Main()
		{
			Console.WriteLine("Which language would you like to see how to say hello in? Please input the number as seen in the list below. ");
			Console.WriteLine("1. German");
			Console.WriteLine("2. Russian");
			Console.WriteLine("3. Japanese");
			Console.WriteLine("4. French");
			Console.WriteLine("5. Spanish");
			string answer = Console.ReadLine();
			
			if (answer == "1")
			{
				Console.WriteLine("Hello in German is hallo. ");
				Console.WriteLine("Please press the enter key to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (answer == "2")
			{
				Console.WriteLine("Hello in Russian is privyet. ");
				Console.WriteLine("Please press the enter key to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (answer == "3")
			{
				Console.WriteLine("Hello in Japanese is konnichiwa. ");
				Console.WriteLine("Please press the enter key to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (answer == "4")
			{
				Console.WriteLine("Hello in French is bonjour. ");
				Console.WriteLine("Please press the enter key to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (answer == "5")
			{
				Console.WriteLine("Hello in Spanish is hola. ");
				Console.WriteLine("Please press the enter key to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else
			{
				Console.WriteLine("There has been an error, it is possible that you have inputted a piece of invalid data. ");
				Console.WriteLine("Please press the enter key to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
		}
	}
}