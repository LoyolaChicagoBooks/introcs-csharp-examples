using System;
namespace IntroCS
{
   class ModMultTable
   {
      
      static void Main()
      {
         string prompt = "\nEnter modulus (0 to quit): ";
         int mod = UI.PromptInt(prompt);
         while (mod > 0) {
            Console.WriteLine();
            MultTable(mod);
            mod = UI.PromptInt(prompt);
         }
      }
                                            // start chunk
      /// Print a table for modular multiplication mod n.
      static void MultTable(int n)
      {
         int numberWidth = ("" + n).Length;
         string colFormat = string.Format("{{0,{0}}} ", numberWidth);
         string rowHeaderFormat = colFormat + "| ";
         Console.Write(rowHeaderFormat,"*"); // start main heading
         for ( int i = 0; i < n; i++) {
            Console.Write(colFormat, i);
         }
         Console.WriteLine();
         
         Console.WriteLine(StringOfReps("-",(numberWidth+1)*(n+1) + 1));
         
         for (int r = 0; r < n; r++) { //rows of table body
            Console.Write(rowHeaderFormat, r);
            for (int c = 0; c < n; c++) {
               Console.Write(colFormat, (r*c) % n);
            }
            Console.WriteLine();
         }
      }
                                             // end chunk
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

