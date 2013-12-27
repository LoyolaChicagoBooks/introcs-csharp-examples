using System;

class Addition2a
{                               // start function chunk
   static string SumProblemString(int x, int y) // with string.Format
   {
      int sum = x + y;
      return string.Format("The sum of {0} and {1} is {2}.", x, y, sum);
   }
                               // end function chunk
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
