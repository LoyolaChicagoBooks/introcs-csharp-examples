using System;

namespace IntroCS
{
   class Traceback  // allows several kinds of run-time error traceback
   {
      static void Main()
      {
         DoRemainder ();
         DoRemainder ();
         DoSTwice ();
         DoSTwice ();
      }

      static void DoRemainder()
      {
         int num = UIF.PromptInt("Enter integer: ");
         int divisor = UIF.PromptInt("Enter divisor: ");
         int r = Remainder (num, divisor);
         Console.WriteLine ("Remainder is " + r);
      }

      static int Remainder(int n, int m)
      {
         Console.WriteLine ("About to calc remainder...");
         return n % m;
      }

      /// Get data, print remainder results
      static void DoSTwice()
      {
         string s = UIF.PromptLine("Enter string: ");
         ShowTwice (s);
      }

      static void ShowTwice(string s)
      {
         Console.WriteLine ("About to print string...");
         Console.WriteLine ("string: " + s + "\nTwice: {0}", s+s);
      }
   }
}
