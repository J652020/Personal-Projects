using System;

namespace favemcgamemode
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("What is your favourite Minecraft gamemode? ");
			string fave = Console.ReadLine();
			Console.WriteLine(fave + " is a really cool gamemode, my favourite is Skyblock. ");
			
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}