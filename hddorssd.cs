using System;

namespace hddorssd
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Would you prefer a HDD or SSD?");
			string favestring = Console.ReadLine();
			string fave = favestring.ToLower();
			if (fave == "hdd")
			{
				Console.WriteLine("Why would you choose a HDD? It's so much slower than an SSD. ");
			}
			else
			{
				Console.WriteLine("Good choice. ");
			}
			Console.WriteLine("Press any key to exit. ");
			Console.ReadKey();
		}
	}
}