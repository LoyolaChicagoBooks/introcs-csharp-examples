using System;

namespace IntroCS
{
   class ReversedString
   {
      static void Main () //testing routine
      {
         string s = UIF.PromptLine ("Enter a line: ");
         Console.WriteLine ("Reversed is:\n{0}", Reverse(s));
      }
                                  // chunk
      /// Return s in reverse order.
      /// If s is "drab", return "bard".
      static string Reverse (string s)
      {
         string rev = "";
         for (int i = s.Length - 1; i >= 0; i--) {
            rev += s[i];
         }
         return rev;
      }
   }                              // end chunk
}
