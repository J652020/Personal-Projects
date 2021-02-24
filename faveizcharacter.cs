using System;

namespace faveizcharacter
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Who is your favourite character from Invader Zim? ");
			string fave = Console.ReadLine();
			Console.WriteLine(fave + " is a cool character, my favourite character is Professor Membrane because of what he did in the film. ");
			Console.WriteLine("Press any key to exit. ");
			Console.ReadKey();
		}
	}
}