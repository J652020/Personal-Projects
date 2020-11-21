using System;

class Program {

	public static float num1 = 0;
	public static float num2 = 0;
	public static float total = 0;
	public static string num1string = "0";
	public static string num2string = "0";

  static void Main()
  {
	Console.WriteLine("Choose a number. ");
	num1string = Console.ReadLine();
	float num1 = float.Parse(num1string);
	Console.WriteLine("Choose a number you want to add to the first one. ");
	num2string = Console.ReadLine();
	float num2 = float.Parse(num2string);
	
	total = (num1 + num2);
	Console.WriteLine(num1 + " + " + num2 + " = " + total);
	
	Console.WriteLine("Press any key to exit. ");
	Console.ReadLine();
	
  }

}
