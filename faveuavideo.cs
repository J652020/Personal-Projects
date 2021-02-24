using System;

namespace faveunusannusvideo
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("What is your favourite Unus Annus video? ");
			string fave = Console.ReadLine();
			Console.WriteLine(fave + " is a really cool video, my personal fave is the escape room one! ");
			Console.WriteLine("Press enter when you want to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}