using System;
using System.IO;

namespace IntroCS
{
   class PrintFileLines  // demo of using EndOfStream test
   {
      public static void Main()
      {
         string userFileName = UI.PromptLine("Enter name of file to print: ");
         var reader = new StreamReader(userFileName);
         while (!reader.EndOfStream) {
            string line = reader.ReadLine();
            Console.WriteLine(line);
         }
         reader.Close();
      }
   }
}
