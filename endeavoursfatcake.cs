using System;

namespace cake
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Does Enji Todoroki (Endeavour) have some fat cake? (y/n)");
			string answer = Console.ReadLine();
			if (answer == "y" || answer == "yes" || answer == "Yes" || answer == "Y")
			{
				Console.WriteLine("That's gay. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (answer == "n" || answer == "no" || answer == "No" || answer == "N")
			{
				Console.WriteLine("You're a liar. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else
			{
				Console.WriteLine("You entered an invalid input. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
		}
	}
}