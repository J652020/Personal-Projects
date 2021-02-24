using System;

namespace subwayorder
{
	class program
	{
		public static string total = "0";
		
		static void Main()
		{
			Console.WriteLine("What bread do you want?");
			string bread = Console.ReadLine();
			Console.WriteLine("How long do you want your sandwich to be? Type in either 6 or 12. ");
			string sizestring = Console.ReadLine();
			int size = int.Parse(sizestring);
			if (size == 6)
			{
				total = "£2.50";
			}
			else
			{
				total = "£5.50";
			}	
			Console.WriteLine("What filling do you want on your sub? ");
			string filling = Console.ReadLine();
			Console.WriteLine("Do you want cheese on it?");
			string cheese = Console.ReadLine();
			Console.WriteLine("Do you want it toasted? ");
			string toasted = Console.ReadLine();
			Console.WriteLine("What salad do you want? Please give a comma seperated list. ");
			string salad = Console.ReadLine();
			Console.WriteLine("What sauce do you want? ");
			string sauce = Console.ReadLine();
			
			Console.WriteLine("You ordered a " + size + " inch sub with " + filling + " on and " + cheese + ", there is(n't) cheese on it. ");
			Console.WriteLine("Your sub is toasted, " + toasted + ", and the salad you have is " + salad + ". ");
			Console.WriteLine("The sauce you have on your sub is " + sauce + ".");
			Console.WriteLine("Your total price of the sub is " + total);
			
			Console.WriteLine("Press any key to exit. ");
			Console.ReadKey();
		}
	}
}