using System;

namespace favecommunitycharacter
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("Who is your favourite community character? ");
			string fave = Console.ReadLine();
			Console.WriteLine(fave + " is a great character! My favourite is Dean Pelton because he's really entertaining.");
			
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}