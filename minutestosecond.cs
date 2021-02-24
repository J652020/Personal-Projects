using System;

namespace MinutesToSeconds
{
    class Program
    {
		public int minutes = 0;
		public string minutesstring = "0";
		public static int seconds = 0;

        public static void Main()
        {
			Console.WriteLine("Please enter how many minutes you want to convert into seconds.");
			string minutesstring = Console.ReadLine();
			int minutes = int.Parse(minutesstring);
			
			seconds = (minutes * 60);
			
			Console.WriteLine(minutes + " in seconds is " + seconds);
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
		}
	}
}