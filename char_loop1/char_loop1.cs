using System;
namespace IntroCS
{
   class CharLoop
   {
      
      static void Main() //testing routine
      {
         string s = UIF.PromptLine("Enter a line: ");
         OneCharPerLine(s);
      } 
                                       // new chunk
      // Print the characters of s, one per line.
      static void OneCharPerLine(string s)
      {
         int i = 0;
         while (i < s.Length) {
            Console.WriteLine(s[i]);
            i++;
         }
      }
   }                              // past new chunk
}

