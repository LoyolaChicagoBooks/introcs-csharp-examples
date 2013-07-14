using System;
namespace IntroCS
{
   class Addition3 // using UIF
   {
      /// Return a sentence stating the sum of x and y.
      static string SumProblemString(int x, int y)
      {
         int sum = x + y;
         string sentence = "The sum of " + x + " and " + y + " is " + sum + ".";
         return sentence;
      }
      
      public static void Main()
      {
         Console.WriteLine(SumProblemString(2, 3)); 
         Console.WriteLine(SumProblemString(12345, 53579));
         int a = UIF.PromptInt("Enter an integer: ");      //NEW
         int b = UIF.PromptInt("Enter another integer: "); //NEW
         Console.WriteLine(SumProblemString(a, b));
      }
   }
}
