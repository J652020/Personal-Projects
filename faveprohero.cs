using System;

namespace faveprohero
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Who is your favourite Pro Hero? ");
			string fave = Console.ReadLine();
			Console.WriteLine("Cool! Mine is Endeavour. ");
			
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}