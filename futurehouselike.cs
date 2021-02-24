using System;

namespace futurehouselike
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Do you like the musical genre future house? (Y/N) ");
			string answer = Console.ReadLine();
			answer.ToLower();
			if (answer == "y")
			{
				Console.WriteLine("Nice, I agree! ");
			}
			else if (answer == "n")
			{
				Console.WriteLine("Can't relate but you do you. ");
			}
			else
			{
				Console.WriteLine("You have entered invalid input. ");
			}
			Console.WriteLine("Press any key to exit. ");
			Console.ReadKey();
		}
	}
}