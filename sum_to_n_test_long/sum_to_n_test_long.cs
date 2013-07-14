using System;
namespace IntroCS
{
   class SumToNTest
   {     
      // Return the sum of the numbers from 1 through n.
      static long SumToN(int n)  //CHANGED:  returns long
      {
         long sum = 1, i = 2;    //CHANGED:  sum is long
         while (i <= n) {
            sum = sum + i;
            i = i + 1;
         }
         return sum;
      }
      
      static void Main()
      {
         int n = UIF.PromptInt("Enter the largest number in the sum: ");
         Console.WriteLine("The sum of 1 through {0} is {1}.", n, SumToN(n));
      }
   }
}

