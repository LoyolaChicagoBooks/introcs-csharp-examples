using System;

namespace IntroCS
{
   class CheckDigits  // test IsDigits (long way)
   {
      
      static void Main() //testing routine
      {
         string s = UIF.PromptLine("Enter a line: ");
         if (IsDigits(s)) {
             Console.WriteLine("Only digits in {0}", s);
         }
         else {
            Console.WriteLine("Not only digits in {0}", s);
         }
      }
                                                 //    new chunk
      /// Return true if s contains one or more digits
      /// and nothing else. Otherwise return false.
      static Boolean IsDigits(string s)
      {
         Boolean allDigitsSoFar = (s.Length > 0);
         int i = 0;
         while (i < s.Length) {
            if (s[i] < '0' || s[i] > '9') {
               allDigitsSoFar = false;
            }
            i++;
         }
         return allDigitsSoFar;
      }
   }                                           // past new chunk
}

