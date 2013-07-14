using System;

class Addition1
{
   static void SumProblem(int x, int y)
   {
      int sum = x + y;
      string sentence = "The sum of " + x + " and " + y + " is " + sum + ".";
      Console.WriteLine(sentence);
   }

   static void Main()
   {
      SumProblem(2, 3);
      SumProblem(12345, 53579);
      Console.Write("Enter an integer: ");
      int a = int.Parse(Console.ReadLine());
      Console.Write("Enter another integer: ");
      int b = int.Parse(Console.ReadLine());
      SumProblem(a, b);
   }
}
