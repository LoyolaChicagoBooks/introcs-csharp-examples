using System;
using System.IO;

namespace IntroCS
{
   class SumFile  // sum a file integers, one per line
   {
      static void Main()
      {
         string filename = UI.PromptLine(
                            "Enter the name of a file of integers: ");
         if (File.Exists(filename)) {
            Console.WriteLine("The sum is {0}", CalcSum(filename));
         }
         else {
            Console.WriteLine("Bad file name {0}", filename);
         }
      }

      /// Read the named file and
      /// return the sum of an int 
      /// from each line that is not just white space. 
      static int CalcSum(string filename)
      {
         int sum = 0;
         var reader = new StreamReader(filename);
         while (!reader.EndOfStream) {
            string sVal = reader.ReadLine().Trim();
            if (sVal.Length > 0) {
               sum += int.Parse(sVal);
            }
         }
         reader.Close();
         return sum;
      }
   }
}
