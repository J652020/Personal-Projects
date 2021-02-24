using System;

namespace LeastFaveBnhaCharacterAgree
{
	class Program
	{
		
		static void Main()
		{
			try
			{
				Console.WriteLine("Minoru Mineta is the worst character in bnha, do you agree? Enter y or n. ");
				string answer = Console.ReadLine();
				
				if (answer == "y" || answer == "Y")
				{
					Console.WriteLine("Cool,,, big same. ");
					Console.WriteLine("Press any key to exit. ");
					Console.ReadLine();
				}
				else if (answer == "n" || answer == "N")
				{
					Console.WriteLine("Ok then, who is your least favourite character? ");
					string leastfave = Console.ReadLine();
					Console.WriteLine("That's understandable. ");
					Console.WriteLine("Press any key to exit. ");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Invalid input, please try again. ");
					System.Threading.Thread.Sleep(3000);
					System.Environment.Exit(1);
				}
			}
			catch (Exception ex1)
			{
				Console.WriteLine(ex1.Message);
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
			}
		}
	}
}