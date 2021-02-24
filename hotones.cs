using System;

namespace WordsearchAssessedCoursework
{
    class Program
    {
		public static string choice = "";
		public static string amount = "";

        public static void Main()
        {
			Console.WriteLine("How many hot wings do you want? ");
			amount = Console.ReadLine();
			
			Console.WriteLine("What flavour hot wings do you want? \nHere are your choices (Enter the number of the one you want): ");
			Console.WriteLine("1. Heartbeat Hot Sauce Jalapeno");
			Console.WriteLine("2. Secret Aardvark");
			Console.WriteLine("3. Scotch Bonnet & Ginger Hot Sauce");
			Console.WriteLine("4. Year of the Dog Thai Chile Pineapple Hot Sauce");
			Console.WriteLine("5. Cutino Chipotle");
			Console.WriteLine("6. Da' Bomb Beyong Insanity");
			Console.WriteLine("7. Black Garlic Carolina Reaper");
			Console.WriteLine("8. Rogue Blood Orange Trinidad Scorpion");
			Console.WriteLine("9. Aka Miso");
			Console.WriteLine("10. Red Habanero & Black Coffee Hot Sauce");
			choice = Console.ReadLine();
			
			Console.WriteLine("You ordered " + amount + " hot wings with " + choice + " sauce on. ");
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
		}	
	}
}