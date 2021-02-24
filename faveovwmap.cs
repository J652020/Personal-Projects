using System;

namespace faveovwmap
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Which map on Overwatch is your favourite? ");
			string fave = Console.ReadLine();
			Console.WriteLine(fave + " is a fun map! My favourite is Hanamura. ");
			Console.WriteLine("Press any key to exit. ");
			Console.ReadKey();
		}
	}
}