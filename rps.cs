using System;

namespace L5_4_Cumulative_Annual_Profit
{
    class Program
    {
		public float use = 0;
		public float cpu = 0;
		
        static void Main(string[] args)
        {
			Random rnd = new Random();
			float cpu = rnd.Next(1,4);
			
			Console.WriteLine("Choose either rock (enter 1), paper (enter 2) or scissors (enter 3): ");
			string use = Console.ReadLine();
			float user = float.Parse(use);
			
			if (cpu == 1 && user == 1 || cpu == 2 && user == 2 || cpu == 3 && user == 3)
			{
				Console.WriteLine("You tied! ");
			}
			else if (cpu == 1 && user == 2)
			{
				Console.WriteLine("You win! ");
			}
			else if (cpu == 1 && user == 3)
			{
				Console.WriteLine("You lose. ");
			}
			else if (cpu == 2 && user == 1)
			{
				Console.WriteLine("You lose. ");
			}
			else if (cpu == 2 && user == 3)
			{
				Console.WriteLine("You win! ");
			}
			else if (cpu == 3 && user == 1)
			{
				Console.WriteLine("You win! ");
			}
			else if (cpu == 3 && user == 2)
			{
				Console.WriteLine("You lose. ");
			}
			
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
        }
    }
}
