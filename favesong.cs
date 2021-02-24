using System;

namespace favesong
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Was ist dein lieblingslied? ");
			string song = Console.ReadLine();
			
			Console.WriteLine(song + " ist gut! ");
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}