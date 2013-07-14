using System;
using System.IO;

namespace IntroCS
{
   class CopyUpper  
   {   
      static void Main() 
      {                                     //start chunk
         var reader = new StreamReader("text.txt");
         var writer = new StreamWriter("upper_text.txt");
         while (!reader.EndOfStream) {
            string line = reader.ReadLine();
            writer.WriteLine(line.ToUpper());
         }
         reader.Close();
         writer.Close();      
      }                                    // end chunk
   }                                                      
}

