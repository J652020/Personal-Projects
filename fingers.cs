using System;

namespace WordsearchAssessedCoursework
{
    class Program
    {
		public string fingers = "0";

        public static void Main()
        {
			Console.WriteLine("Please enter how many fingers you have. ");
			string fingers = Console.ReadLine();
			Console.WriteLine("You have " + fingers + " fingers");
			
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
		}
	}
}