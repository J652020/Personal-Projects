using System;

namespace favewfscharacter
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Who is your favourite Wolfenstein character? ");
			string fave = Console.ReadLine();
			Console.WriteLine("Oh! " + fave + " is a cool character, my favourite is Klaus. ");
			
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}