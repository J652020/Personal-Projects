using System;

namespace WordsearchAssessedCoursework
{
    class Program
    {
		public static string fave = "";
		
		public static void Main()
        {
			Console.WriteLine("Who is your favourite My Hero Academia character? ");
			fave = Console.ReadLine();
			
			Console.WriteLine(fave + " is my favourite mha character too! ");
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
		}
	}
}
