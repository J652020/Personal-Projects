using System;

namespace faveaccent
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("What is your favourite accent? ");
			string fave = Console.ReadLine();
			
			Console.WriteLine(fave + " is a cool accent, my favourite is German.");
			Console.WriteLine("Press enter when you want to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}