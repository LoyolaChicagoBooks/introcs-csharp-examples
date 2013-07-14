using System;

namespace IntroCS
{
   public class GCDBasic
   {
                                              // chunk-gcd-begin
      /// Return the greatest common divisor of positive numbers.
      public static int GreatestCommonDivisor (int a, int b)
      {
         int n = Math.Min (a, b);
         int gcd = 1, i = 1;

         while (i <= n) {
            if (a % i == 0 && b % i == 0) {
               gcd = i;
            }
            i++;
         }
         return gcd;
      }
                                              // chunk-gcd-end
      static void Main ()
      {
         int a = UI.PromptInt ("Enter an integer: ");
         int b = UI.PromptInt ("Enter another integer: ");
         Console.WriteLine ("The final result is: gcd({0}, {1}) = {2}.",
                        a, b, GreatestCommonDivisor (a, b));
      }
   }
}
