using System;

class PrintParam
{                                   // start chunk
   /// Demonstrate the use of command line parameters. 
   static void Main(string[] args)
   {
      Console.WriteLine("There are {0} command line parameters.", args.Length);
      foreach(string s in args) {
         Console.WriteLine(s);
      }

   }
}                                   // end chunk



