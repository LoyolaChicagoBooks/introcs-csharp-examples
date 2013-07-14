using System;
namespace IntroCS
{
   class SumToNTest  // INCORRECT!
   {
      //                                      bad chunk
      /// Return the sum of the numbers from 1 through n.
      static long SumToN(int n)  //CHANGED:  quick and WRONG
      {
         int average = (n+1)/2;    //from Gausse's motivation
         return n*average;
      }
      //                                   end bad chunk
      static void Main()
      {
         int n = UIF.PromptInt("Enter the largest number in the sum: ");
         Console.WriteLine("The sum of 1 through {0} is {1}.", n, SumToN(n));
      }
   }
}

