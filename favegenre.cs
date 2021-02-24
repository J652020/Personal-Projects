using System;

namespace favegenre
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("What genre of music is your favourite? ");
			string genre = Console.ReadLine();
			Console.WriteLine(genre + " is a good genre. Personally, I like all sorts. ");
				
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}