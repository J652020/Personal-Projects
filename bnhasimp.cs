using System;

namespace mhasimp
{
	class program
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Which My Hero Academia character do you simp for? ");
				string simpfor = Console.ReadLine();
				
				if (simpfor == "mineta")
				{
					Console.WriteLine("Ew");
					Console.WriteLine("Press enter to exit. ");
					Console.ReadLine();
					System.Environment.Exit(1);
				}
				if (simpfor == "minoru mineta")
				{
					Console.WriteLine("Ew");
					Console.WriteLine("Press enter to exit. ");
					Console.ReadLine();
					System.Environment.Exit(1);
				}
				if (simpfor == "minoru")
				{
					Console.WriteLine("Ew");
					Console.WriteLine("Press enter to exit. ");
					Console.ReadLine();
					System.Environment.Exit(1);
				}
				else
				{
					Console.WriteLine("They are a cool character! I simp for Mirio Togata personally. ");
					Console.WriteLine("Press enter to exit. ");
					Console.ReadLine();
					System.Environment.Exit(1);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("There has been an error. Please restart the program. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
		}
	}
}