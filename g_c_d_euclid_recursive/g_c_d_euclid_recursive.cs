using System;

namespace IntroCS
{
   public class GCDEuclidRecursive
   {
                                                 // chunk-gcd-begin
      /// Return the greatest comon divisor of nonnegative numbers,
      /// not both 0.
      public static int GreatestCommonDivisor (int a, int b)
      {
         if (b == 0) {
            Console.WriteLine ("gcd({0}, {1}) = {0}", a, b);
            return a;
         } else {
            Console.WriteLine (
            "gcd({0}, {1}) = gcd({1}, {0} mod {1} = gcd({1}, {2})",
             a, b, a % b);
            return GreatestCommonDivisor (b, a % b);
         }
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
