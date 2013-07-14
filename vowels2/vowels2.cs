using System;
namespace IntroCS
{
   class Vowels
   {      
      static void Main() //testing routine
      {
         string s = UIF.PromptLine("Enter a line: ");
         PrintVowels(s);
      } 
                                       //  new chunk
      /// Print the vowels (aeiou) in s, one per line.
      static void PrintVowels(string s)
      {
         int i = 0;
         string vowels = "aeiouAEIOU";
         while (i < s.Length) {
            if (vowels.Contains(""+s[i])) {
               Console.WriteLine(s[i]);
            }
            i++;
         }
      }
   }                              // past new chunk
}

