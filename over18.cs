using System;

namespace WordsearchAssessedCoursework
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please enter your age. ");
			agestring = Console.ReadLine();
			int age = int.Parse(agestring);
			
			if (age >= 18)
			{
				Console.WriteLine("This person can buy alcohol. ")
			}
			else
			{
				Console.WriteLine("This person cannot buy alcohol. ");
			}
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
        }
    }
}
