using System;

class ModMultTable
{
   static void Main()
   {                                         // start chunk
      //heading
      Console.Write("* | ");
      for ( int i = 0; i < 7; i++) {  //column headings
         Console.Write(i + " ");
      }
      Console.WriteLine();

      Console.WriteLine(StringOfReps("-", 1 + (7+1)*(1+1)));

      for (int r = 0; r < 7; r++) {     // table body
         Console.Write(r + " | ");      // row heading
         for (int c = 0; c < 7; c++) {  // data columns
            int modProd = (r*c) % 7;
            Console.Write(modProd + " ");
         }
         Console.WriteLine();
      }
   }                                           // end chunk

   static string StringOfReps(string s, int n)
   {
      string ret = "";
      for (int i = 0; i < n; i++) {
         ret += s;
      }
      return ret;
   }
}


