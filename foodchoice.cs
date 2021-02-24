using System;

namespace foodchoice
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("What do you want for tea? You have a choice between 1. Popeye Pasta, 2. Stir Fry and 3. Toasties.");
			Console.ReadLine();
			Console.WriteLine("Go make it then, scrub.");
			
			Console.WriteLine("Press enter to exit");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}