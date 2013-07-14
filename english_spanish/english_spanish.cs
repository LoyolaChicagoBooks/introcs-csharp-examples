using System;
using System.Collections.Generic;

namespace IntroCS
{
   class EnglishSpanish
   {
      public static void Main(string[] args)
      {
         var e2sp = new Dictionary<string, string>();
         e2sp["one"] = "uno";
         e2sp["two"] = "dos";
         e2sp["three"] = "tres";

         Console.WriteLine("Count in Spanish:\n{0}, {1}, {2}...",
                           e2sp["one"], e2sp["two"], e2sp["three"]);

         Console.WriteLine("\nKeys:");
         foreach (string s in e2sp.Keys) {
            Console.WriteLine(s);
         }
      }
   }
}
