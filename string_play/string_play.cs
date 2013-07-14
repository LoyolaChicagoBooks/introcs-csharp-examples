using System;

class StringPlay
{
	
	static void Main()
	{
		Console.WriteLine("Enter three lines:");
		string line1 = Console.ReadLine(),
             line2 = Console.ReadLine(),
             line3 = Console.ReadLine();

		Console.WriteLine("Lines in opposite order:");
		Console.WriteLine(line3);
		Console.WriteLine(line2);
		Console.WriteLine(line1);
		
      Console.WriteLine("First line in upper case:  " + line1.ToUpper());
	}
}
