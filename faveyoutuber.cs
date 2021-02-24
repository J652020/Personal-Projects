using System;

namespace faveyoutuber
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Please select your favourite youtuber from the list below by inputting the number next to their name. ");
			Console.WriteLine("1. Markiplier. ");
			Console.WriteLine("2. CrankGamePlays. ");
			Console.WriteLine("3. JackSepticEye. ");
			Console.WriteLine("4. PewDiePie. ");
			Console.WriteLine("5. DanTDM. ");
			string response = Console.ReadLine();
			
			if (response == "1")
			{
				Console.WriteLine("Markiplier's net worth is $24 million. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (response == "2")
			{
				Console.WriteLine("CrankGamePlays' net worth is $250k. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (response == "3")
			{
				Console.WriteLine("JackSepticEye's net worth is $16 million. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (response == "4")
			{
				Console.WriteLine("PewDiePie's net worth is $40 million. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else if (response == "5")
			{
				Console.WriteLine("DanTDM's net worth is $35 million. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			else
			{
				Console.WriteLine("There has been an error, you have most likely entered invalid data. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
		}
	}
}