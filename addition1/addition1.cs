using System;

class Addition2
{
   static string SumProblemString(int x, int y)
   {
      int sum = x + y;
      string sentence = "The sum of " + x + " and " + y + " is " + sum + ".";
      return sentence;
   }

   static void Main()
   {
      Console.WriteLine(SumProblemString(2, 3));
      Console.WriteLine(SumProblemString(12345, 53579));
      Console.Write("Enter an integer: ");
      int a = int.Parse(Console.ReadLine());
      Console.Write("Enter another integer: ");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine(SumProblemString(a, b));
   }
}
   