using System;

namespace IntroCS
{
   class ReversePrint
   {
      static void Main() //testing routine
      {
         string s = UIF.PromptLine("Enter a line: ");
         Console.WriteLine ("Reversed:");
         PrintReversed("\n"+s);
      } 
                                // chunk
      /// Print s in reverse order; no extra newlines
      static void PrintReversed(string s)
      {
         int i = s.Length-1;
         while (i >= 0 ) {
            Console.Write(s[i]);
            i--;
         }
      }
   }                           
}
