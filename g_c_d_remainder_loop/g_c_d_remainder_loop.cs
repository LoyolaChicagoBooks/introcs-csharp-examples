using System;

namespace IntroCS
{
   public class GCDEuclidRemainderLoop
   {                                                   //  gcd chunk 
      /// Return the greatest comon divisor of nonnegative numbers,
      /// not both 0.
      public static int GreatestCommonDivisor (int a, int b)
      {
         while (b != 0) {
            int r = a % b;
            Console.WriteLine (  // just to show the sequence
               "gcd({0}, {1}) = gcd({1}, {0} mod {1}) = gcd({1}, {2})",
               a, b, r);
            a = b;
            b = r;
         }
         Console.WriteLine ("gcd({0}, {1}) = {0}", a, b); // show the sequence
         return a;
      } 
                                                       // gcd end chunk
      static void Main ()
      {
         int a = UI.PromptInt ("Enter an integer: ");
         int b = UI.PromptInt ("Enter another integer: ");
         Console.WriteLine ("The final result is: gcd({0}, {1}) = {2}",
                        a, b, GreatestCommonDivisor (a, b));
      }
   }
}
