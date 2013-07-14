using System;
using System.IO;

namespace IntroCS
{
   class PrintFirstFile  // basics of reading file lines 
   {
      public static void Main()  
      {
         StreamReader reader = new StreamReader("sample.txt");
         string line = reader.ReadLine();  // first line
         Console.WriteLine(line);
         line = reader.ReadLine();         // second line
         Console.WriteLine(line);
         reader.Close();                   
      }
   }
}
