using System;

namespace shampoo
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("What shampoo do you use? ");
			string shampoo = Console.ReadLine();
			Console.WriteLine(shampoo + " is a good choice for healthy hair! I use Vosene because it smells super good. ");
			
			Console.WriteLine("Press enter when you are ready to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}