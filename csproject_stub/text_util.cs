using System;
using System.IO;
namespace IntroCS
{
   
   /// File utilities for reading from a text file.
   public class TextUtil
   {
      /// Read a long line and return it wrapped into lines.
      /// Such data is easiest generated in a regular word
      /// processor that automatically wraps lines, 
      /// so any paragraph is just stored as one long line..
      public static string LineWrap(StreamReader reader)
      {
         return WordWrap(reader.ReadLine(), 79);
      }

      private static char[] noChar = {};

      /// Split s at any number of whitespace characters.
      ///  No empty strings are inserted. 
      public static string[] SplitWhite(string s)
      {   // The function call shortens this mouthfull!
         return s.Split(noChar, StringSplitOptions.RemoveEmptyEntries);
      }

      /// Add line breaks to s so it wraps within a specified
      /// number of columns. 
      public static string WordWrap(string s, int columns)
      {
         string wrapped = "";
         s = s.Trim();
         while (s.Length > columns) {
            int i = s.LastIndexOf(" ", columns);
            if (i == -1) {
               i = columns;
            }
            wrapped += s.Substring(0, i).Trim();
            s = s.Substring(i).Trim();
            if (s.Length > 0) {
               wrapped += "\n";
            }
         }
         wrapped += s;
         return wrapped;
      }
   }
}
