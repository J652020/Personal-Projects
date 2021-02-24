using System;

namespace faveingloriousbcharacter
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Who is your least favourite Inglorious B character? ");
			string leastfave = Console.ReadLine();
			Console.WriteLine("Your least favourite is " + leastfave + "? Why? ");
			Console.ReadLine();
			Console.WriteLine("Understandable, they are a scumbag. ");
			
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}