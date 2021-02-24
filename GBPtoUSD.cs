using System;

namespace WordsearchAssessedCoursework
{
    class Program
    {
		public static double amount = 0;
		public static string amountstring = "0";

        public static void Main()
        {
			Console.WriteLine("Please enter the amount of GBP you want converting to USD. ");
			amountstring = Console.ReadLine();
			double amount = double.Parse(amountstring);
			
			amount = (amount * 1.29412);
			Console.WriteLine("The amount you entered in GBP is " + amount + " in USD. ");
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
		}
	}
}