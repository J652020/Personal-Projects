using System;

namespace abo
{
	class program
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("What role do you think you would take on in an omegaverse reality? ");
				string role = Console.ReadLine();
				
				if (role == "alpha")
				{
					Console.WriteLine("Dealing with a rut without an omega sounds like it sucks. ");
					Console.WriteLine("Press enter to exit. ");
					Console.ReadLine();
					System.Environment.Exit(1);
				}
				else if (role == "beta")
				{
					Console.WriteLine("Being friends with an alpha or an omega while they are in their rut or heat sounds difficult. ");
					Console.WriteLine("Press enter to exit. ");
					Console.ReadLine();
					System.Environment.Exit(1);
				}
				else if (role == "omega")
				{
					Console.WriteLine("Dealing with a heat without an alpha sounds rough. ");
					Console.WriteLine("Press enter to exit. ");
					Console.ReadLine();
					System.Environment.Exit(1);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("You have entered an invalid input, please try again. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
		}
	}
}