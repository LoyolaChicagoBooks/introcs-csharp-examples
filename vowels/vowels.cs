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
      //                                         new chunk
      /// Print the vowels (aeiou) in s, one per line.
      static void PrintVowels(string s)
      {
         int i = 0;
         while (i < s.Length) {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' ||
                s[i] == 'o' || s[i] == 'u') {
               Console.WriteLine(s[i]);
            }
            i = i+1;
         }
      }
   }                                       // past new chunk
}

