using System;
namespace IntroCS
{
   class SumToNTest  // INCORRECT!
   {
      //                                      bad chunk
      /// Return the sum of the numbers from 1 through n.
      static long SumToN(int n)  //CHANGED:  quick and still WRONG
      {
         long sum = n*(n+1)/2;  // final division will produce an integer
         return sum;
      }
      //                                   end bad chunk
      static void Main()
      {
         int n = UIF.PromptInt("Enter the largest number in the sum: ");
         Console.WriteLine("The sum of 1 through {0} is {1}.", n, SumToN(n));
      }
   }
}


