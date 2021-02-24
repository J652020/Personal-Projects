using System;

class Program {
	
	public string moduleexists = "y";
	public string wires;

  static void Main()
  {
	Console.WriteLine("Which module are you dealing with? ");
	string module = Console.ReadLine();
	
	while (moduleexists == "y")
	
	if (module == wires)
	{
		Console.WriteLine("How many wires are there? ");
		string amount = Console.ReadLine();
		if (amount == "3")
			Console.WriteLine("Are there any red wires? (y/n) ");
			string redwire = Console.ReadLine();
			if (redwire == "y")
			{
				Console.WriteLine("Is the last wire white? (y/n) ");
				string whitewire = Console.ReadLine();
				if (whitewire == "y")
				{
					Console.WriteLine("Cut the last wire. ");
				}
				else if (whitewire == "n")
				{
					Console.WriteLine("Is there more than one blue wire? (y/n) ");
					string bluewire = Console.ReadLine();
					if (bluewire == "y")
					{
						Console.WriteLine("Cut the last blue wire. ");
					}
					else if (bluewire == "n")
					{
						Console.WriteLine("Cut the last wire. ");
					}
				}
			}
			else if (redwire == "n")
			{
				Console.WriteLine("Cut the last wire. ");
			}
	}
	Console.WriteLine("Do you need to deal with another module? (y/n) ");
	string moduleexists = Console.ReadLine();
	Console.WriteLine("Press any key to exit. ");
	Console.ReadLine();
	
  }

}
