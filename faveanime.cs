using System;

namespace faveanime
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("What is your favourit anime series?");
			string fave = Console.ReadLine();
			Console.WriteLine(fave + " is really good from what I've seen of it, but My Hero Academia is my personal favourite. ");
			
			Console.WriteLine("Press enter to exit.");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}