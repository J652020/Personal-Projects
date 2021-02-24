using System;

namespace favevocaloid
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Who is your favourite vocaloid? ");
			string fave = Console.ReadLine();
			Console.WriteLine(fave + " is definitely one of the best! ");
			Console.WriteLine("Press enter when you want to exit.");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}