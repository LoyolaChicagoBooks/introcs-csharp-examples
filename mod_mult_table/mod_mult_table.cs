using System;
namespace IntroCS
{
   class ModMultTable
   {
      
      static void Main()
      {
         int mod;
         do {
            mod = UI.PromptInt("\nEnter modulus (0 to quit): ");
            if (mod > 0) {
               Console.WriteLine();
               MultTable(mod);
            }
         } while (mod > 0);
      }
                                            // start chunk
      /// Print a table for modular multiplication mod n.
      static void MultTable(int n)
      {
         int numberWidth = ("" + n).Length;
         string colFormat = string.Format("{{0,{0}}} ", numberWidth);
         string headerFormat = colFormat + "| ";
         // heading
         Console.Write(headerFormat,"*");
         for ( int i = 0; i < n; i++) {
            Console.Write(colFormat, i);
         }
         Console.WriteLine();
         
         Console.WriteLine(StringOfReps("-",(numberWidth+1)*(n+1) + 1));
         
         for (int r = 0; r < n; r++) { //rows of table body
            Console.Write(headerFormat, r);
            for (int c = 0; c < n; c++) {
               Console.Write(colFormat, (r*c) % n);
            }
            Console.WriteLine();
         }
      }
                                             // StringRep chunk
      /// Return s repeated n times.
      static string StringOfReps(string s, int n)
      {
         string ret = "";
         for (int i = 0; i < n; i++) {
            ret += s;
         }
         return ret;
      }
      
      
   }
}

