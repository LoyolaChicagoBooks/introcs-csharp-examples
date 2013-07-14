using System;
using System.IO;

namespace IntroCS
{
   class FIOTest
   {
      public static void Main(string[] args)
      {
         string sample = "sample.txt";
         string output = "output.txt";
         Console.WriteLine("Directory of {0}: {1}", 
                           sample, FIO.GetLocation(sample));
         Console.WriteLine("Path to  {0}: {1}", 
                           sample, FIO.GetPath(sample));
         StreamReader reader1 = FIO.OpenReader(sample);
         if (reader1 != null) {
            Console.Write(reader1.ReadToEnd());
            Console.WriteLine("First reader test passed.");
            reader1.Close();
         }

         StreamReader reader2 = FIO.OpenReader(FIO.GetLocation(sample), 
                                               sample);
         if (reader2 != null) {
            Console.WriteLine("Second reader test passed.");
            reader2.Close();
         }

         StreamWriter writer1 = FIO.OpenWriter(FIO.GetLocation(sample), 
                                               output);
         writer1.WriteLine("File in the same directory as {0}.", sample);
         writer1.Close();
         Console.WriteLine("Writer test passed; file written at \n {0}", 
                           FIO.GetPath(output));
      }
   }
}
