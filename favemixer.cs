using System;

namespace favemixer
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("What is your favourite mixer? ");
			string fave = Console.ReadLine();
			Console.WriteLine("Cool! My favourite mixer is lemonade, it's ever so slightly s p i c y and I love it.");
			
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}