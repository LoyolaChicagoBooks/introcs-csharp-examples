using System;
using System.IO;

namespace IntroCS
{
   class GradeFiles
   {
      /// Process grade files based on a class abbreviation
      /// on the command line, or provided interactively.
      public static void Main(string[] args)
      {
         // TEMPORARY line to get oriented to the file system:
         Console.WriteLine("Current directory: " + 
                           Directory.GetCurrentDirectory());
      }
                                           // codeIndex chunk                                          
      /// Take the first letter code for a catagory, and 
      /// return the index of that category in categories.
      static int codeIndex(string code, string[] categories)
      {
         for (int i = 0; i < categories.Length; i++) {
            if (categories[i].Trim().StartsWith(code)) {
               return i;
            }
         }
         return -1; //required by compiler: shouldn't reach
      }
   }                                   // end codeIndex chunk
}
