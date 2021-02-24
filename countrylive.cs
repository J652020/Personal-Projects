using System;

namespace country
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("What country do you want to live in when you are older? ");
			string country = Console.ReadLine();
			
			Console.WriteLine(country + " is a good choice!");
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}