using System;

namespace faveicecream
{
	class program
	{
		static void Main()
		{
			Console.WriteLine("What is your favourite flavour of ice cream? \n1. Chocolate \n2.Strawberry \n3. Vanilla ");
			Console.WriteLine("Enter 1, 2 or 3 depending on your favourite flavour from the list above. ");
			string favestring = Console.ReadLine();
			int fave = int.Parse(favestring);
			
			if (fave == 1)
			{
				Console.WriteLine("Cool! Chocolate is an... interesting flavour to say the least. ");
			}
			else if (fave == 2)
			{
				Console.WriteLine("Awesome, strawberry is my favourite flavour too! ");
			}
			else if (fave == 3)
			{
				Console.WriteLine("Vanilla is a good flavour. ");
			}
			else
			{
				Console.WriteLine("You have entered an invalid input, please try again. ");
			}
			Console.WriteLine("Press enter to exit. ");
			Console.ReadLine();
			System.Environment.Exit(1);
		}
	}
}