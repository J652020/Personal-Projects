using System;

namespace dpcalc3d
{
	class program
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Please enter the top number of your first vector. ");
				string num1string = Console.ReadLine();
				int num1 = int.Parse(num1string);
				Console.WriteLine("Please enter the middle number of your first vector. ");
				string num2string = Console.ReadLine();
				int num2 = int.Parse(num2string);
				Console.WriteLine("Please enter the bottom number of your first vector. ");
				string num3string = Console.ReadLine();
				int num3 = int.Parse(num3string);
				Console.WriteLine("Please enter the top number of your second vector. ");
				string num4string = Console.ReadLine();
				int num4 = int.Parse(num4string);
				Console.WriteLine("Please enter the middle number of your second vector. ");
				string num5string = Console.ReadLine();
				int num5 = int.Parse(num5string);
				Console.WriteLine("Please enter the bottom number of your second vector. ");
				string num6string = Console.ReadLine();
				int num6 = int.Parse(num6string);
				
				int sum1 = (num1 * num4);
				int sum2 = (num2 * num5);
				int sum3 = (num3 * num6); 
				
				int total = (sum1 + sum2 + sum3);
				
				Console.WriteLine("The dot product of the two 3D vectors you entered is " + total);
				Console.WriteLine("Press enter when you want to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
			catch
			{
				Console.WriteLine("You entered some invalid data, please try again. ");
				Console.WriteLine("Press enter to exit. ");
				Console.ReadLine();
				System.Environment.Exit(1);
			}
		}
	}
}