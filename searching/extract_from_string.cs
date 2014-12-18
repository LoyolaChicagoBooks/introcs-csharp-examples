using System;

namespace IntroCS
{
   public class ExtractFromString
   {
      /// Return an array of non-empty strings that are separated
      /// in the original string by any combination of commas and blanks.
      /// Example:  ExtractItems("  extra  spaces,plus,  more, ") returns
      /// an array containing {"extra", "spaces", "plus", "more"} 
      public static string[] ExtractItems(string s)
      {
         s = s.Replace (",", " "); //only worry about blanks
         int dataLength = 0;
         string[] okEmptyStrings = s.Split(' '); 
         foreach (string w in okEmptyStrings) { 
            if (w.Length > 0) { //ending or consecutive blanks generate ""
               dataLength++;
            }
         } 
         string[] data = new string[dataLength];
         int i = 0;  // next open index in data
         foreach (string w in okEmptyStrings) { 
            if (w.Length > 0) {  // ignore "" from Split
               data [i] = w;
               i++;
            }
         }
         return data;

      }
      /// Return ints from space/comma separated integers in a string.
      public static int[] IntsFromString(string input)
      {
         string[] integers = ExtractItems(input); 
         int[] data = new int[integers.Length];
         for(int i = 0; i < data.Length; i++) { 
            data[i] = int.Parse(integers[i]);
         }
         return data;
      }
   }
}

