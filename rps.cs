using System;

namespace L5_4_Cumulative_Annual_Profit
{
    class Program
    {
		public static int user = 0;
		public static int cpu = 0;
		
        static void Main(string[] args)
        {
			Random rnd = new Random();
			
			while (cpu = 0)
			{
				int cpu = rnd.Next(1, 4);
			}
			
			Console.WriteLine("Choose either rock (enter 1), paper (enter 2) or scissors (enter 3): ");
			Console.ReadLine(user);
			
			if (comp = user)
			{
				Console.WriteLine("You tied! ");
			}
			else if (comp = "1" && user = "2")
			{
				Console.WriteLine("You win! ");
			}
			else if (comp = "1" && user = "3")
			{
				Console.WriteLine("You lose. ");
			}
			else if (comp = "2" && user = "1")
			{
				Console.WriteLine("You lose. ");
			}
			else if (comp = "2" && user = "3")
			{
				Console.WriteLine("You win! ");
			}
			else if (comp = "3" && user = "1")
			{
				Console.WriteLine("You win! ");
			}
			else if (comp = "3" && user = "2")
			{
				Console.WriteLine("You lose. ");
			}
			
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
        }
    }
}
