using System;

namespace favevideogame
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Please enter your name. ");
			string name = Console.ReadLine();
			Console.WriteLine("Hello " + name + ", what is your favourite video game? ");
			string fave = Console.ReadLine();
			Console.WriteLine( fave + " is a great game " + name + "! My favourite video game is Minecraft. ");
			
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}