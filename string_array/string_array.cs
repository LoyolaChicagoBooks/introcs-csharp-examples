using System;

namespace IntroCS
{
   public class StringArray
   {
      // chunk PrintStrings
      /// Print the strings in data, one per line.
      public static void PrintStrings(string[] data)
      {
         foreach( string s in data) {
            Console.WriteLine(s);
         }
      }
      // chunk InputNStrings
      /// Return an array with string data obtained from the user.
      /// The length of the array and the number of entries to
      ///   prompt the user for is n.
      public static string[] InputNStrings(int n)
      {
         string[] lines = new string[n];
         Console.WriteLine ("Enter {0} string(s).", n);
         for (int i = 0; i < n; i++) {
            lines[i] = UI.PromptLine("next string: ");
         }
         return lines;
      }
      // chunk NewUpper
      /// Return an array that is the same as data
      /// except all strings are in upper case.
      public static string[] NewUpper(string[] data)
      {
         string[] upper = new string[data.Length];
         for (int i = 0; i < data.Length; i++) {
            upper[i] = data[i].ToUpper();
         }
         return upper;
      }
      // chunk AllToUpper
      /// Modifiy the array data so
      ///   all strings are in upper case.
      public static void AllToUpper(string[] data)
      {
         for (int i = 0; i < data.Length; i++) {
            data[i] = data[i].ToUpper();
         }
      }
   }
}

