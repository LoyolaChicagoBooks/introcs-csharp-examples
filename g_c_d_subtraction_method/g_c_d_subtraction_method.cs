using System;

namespace IntroCS
{
   public class GCDSubtractionMethod
   {
      // chunk-gcd-begin
      public static int GreatestCommonDivisor (int a, int b)
      {
         int c;
         while (a != b) {
            while (a > b) {
               c = a - b;
               a = c;
            }
            while (b > a) {
               c = b - a;
               b = c;
            }
         }
         return a;
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
