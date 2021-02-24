using System;

namespace favficcharacter
{
	class program
	{
		public static int x = 1;
		
		static void Main()
		{
			Console.WriteLine("How many favourite fictional characters do you have? ");
			string numstring = Console.ReadLine();
			int num = int.Parse(numstring);
			while(x <= num)
			{
				Console.WriteLine("Who is favourite character number " + x + "?");
				Console.ReadLine();
				x = x + 1;
			}
			Console.WriteLine("Those are good choices! Mine are Enji Todoroki, Mirio Togata and The Medic from tf2. ");
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}