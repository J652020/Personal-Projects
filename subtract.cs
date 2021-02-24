using System;

namespace SubtractingOneNumberFromAnother
{
	class Program
	{
		public int num1 = 0;
		public int num2 = 0;
		public int num3 = 0;
	
		static void Main()
		{
			Console.WriteLine("Enter a number you want to subtract another number from. ");
			string num1string = Console.ReadLine();
			int num1 = int.Parse(num1string);
			Console.WriteLine("Enter a number you want to subtract from the first number. ");
			string num2string = Console.ReadLine();
			int num2 = int.Parse(num2string);
			
			int num3 = (num1 - num2);
			Console.WriteLine(num1 + " - " + num2 + " = " + num3);
			
			Console.WriteLine("Press any key to exit. ");
			Console.ReadLine();
		}	
	}
}