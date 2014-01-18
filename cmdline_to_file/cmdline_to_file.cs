using System;
using System.IO;

namespace IntroCS
{
   class FileTest
   {
      public static void Main (string[] args)
      {
         var outf = new StreamWriter(args[0]);
         outf.Write (args[1]);
         outf.Close ();
      }
   }
}
