using System;
using System.IO;

namespace IntroCS
{
   class FirstFile  // basics of file writing
   {
      public static void Main()
      {
         StreamWriter writer = new StreamWriter("sample.txt");
         writer.WriteLine("This program is writing");
         writer.WriteLine("our first file.");
         writer.Close();
      }
   }
}
