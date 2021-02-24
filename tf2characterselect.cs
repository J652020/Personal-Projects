using System;

namespace ChooseYourCharacter
{
    class Program
	{
		public static void Main()
		{
			try
			{
				Console.WriteLine("Please enter the number of the character you would like to play as. ");
				Console.WriteLine("1. Scout");
				Console.WriteLine("2. Soldier");
				Console.WriteLine("3. Pyro");
				Console.WriteLine("4. Demoman");
				Console.WriteLine("5. Heavy");
				Console.WriteLine("6. Engineer");
				Console.WriteLine("7. Medic");
				Console.WriteLine("8. Sniper");
				Console.WriteLine("9. Spy");
				string selection = Console.ReadLine();
				
				if (selection == "1")
				{
					Console.WriteLine("Thank you for picking the Scout. ");
				}
				else if (selection == "2")
				{
					Console.WriteLine("Thank you for picking the Soldier. ");
				}
				else if (selection == "3")
				{
					Console.WriteLine("Thank you for picking the Pyro. ");
				}
				else if (selection == "4")
				{
					Console.WriteLine("Thank you for picking the Demoman. ");
				}
				else if (selection =="5")
				{
					Console.WriteLine("Thank you for picking the Heavy. ");
				}
				else if (selection == "6")
				{
					Console.WriteLine("Thank you for picking the Engineer. ");
				}
				else if (selection == "7")
				{
					Console.WriteLine("Thank you for picking the Medic. ");
				}
				else if (selection == "8")
				{
					Console.WriteLine("Thank you for picking the Sniper. ");
				}
				else if (selection == "9")
				{
					Console.WriteLine("Thank you for picking the Spy. ");
				}
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
			}
		}
	}
}