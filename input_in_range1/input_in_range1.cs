using System;
namespace IntroCS
{
   class PromptUser
   {     
      static void Main() //testing routine
      {
         int n = PromptIntInRange("Enter a score (0 through 100): ", 0, 100);
         Console.WriteLine("Your score is {0}.", n);
         Console.WriteLine("Try another test.");
         n = PromptIntInRange("Enter a number (-10 through 10): ", -10, 10);
         Console.WriteLine("Your number is {0}.", n);
      }      
                                                   //  new chunk
      /// Prompt the user to obtain an int until the response is in the
      /// range [lowLim, highLim].  Then return the int in range.
      static int PromptIntInRange(string prompt, int lowLim, int highLim)
      {
         int number = UIF.PromptInt(prompt);
         while (number < lowLim || number > highLim) {
            Console.WriteLine("{0} is out of range!", number);
            number = UIF.PromptInt(prompt);
         }
         return number;
      }
   }                                           // past new chunk
}

