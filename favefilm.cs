using System;

namespace favespirit
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("What is your favourite film? ");
			string fave = Console.ReadLine();
			
			Console.WriteLine(fave + " is a good choice! I don't have a favourite but The Matrix is pretty good. ");
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}