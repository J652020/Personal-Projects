using System;

namespace favecolour
{
	class program
	{
		public static void Main()
		{
			Console.WriteLine("What is your favourite colour? ");
			string favecolour = Console.ReadLine();
			
			Console.WriteLine(favecolour + " is a nice colour, but my favourite is blue. ");
			Console.WriteLine("Press any key to exit");
			Console.ReadLine();
			System.Environment.Exit(1);
			
		}
	}
}