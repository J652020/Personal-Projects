using System;

class Program {
    
  static void Main()
  {
    Console.WriteLine("Please enter temperature in Farhenheit");
    string farhenheitString = Console.ReadLine();
    float farhenheit = int.Parse(farhenheitString);
    float celsius = ((farhenheit - 32) * 5) / 9;
    Console.WriteLine(farhenheit + " degrees Farhenheit is equal to " + celsius + " degrees Celsius");
	Console.WriteLine("Press any key to exit. ");
	Console.ReadLine();
  }
    
}
