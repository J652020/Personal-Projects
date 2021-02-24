using System;

namespace favespirit
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("What is your favourite alcoholic spirit? ");
			string fave = Console.ReadLine();
			
			Console.WriteLine(fave + " is a good choice! Mine is Blue Curacao. ");
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}