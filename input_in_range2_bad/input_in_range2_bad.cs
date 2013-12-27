using System;
namespace IntroCS
{
   class PromptUser // Infinite loop version!
   {                                        
      static void Main() //testing routine
      {
         int n = PromptIntInRange("Enter a score: ", 0, 100);
         Console.WriteLine("Your score is {0}.", n);
         Console.WriteLine("Try another test.");
         n = PromptIntInRange("Enter a number: ", -10, 10);
         Console.WriteLine("Your number is {0}.", n);
      }      
                                                 
      /// Prompt the user to obtain an int until the response is in the
      /// range [lowLim, highLim].  Then return the int in range.
      /// Use the specified prompt, adding a reminder of the allowed range.
      static int PromptIntInRange(string prompt, int lowLim, int highLim)
      {
         string longPrompt = string.Format("{0} ({1} through {2}) ",
                                           prompt, lowLim, highLim);
                                                            // start chunk  
         int number = UIF.PromptInt(longPrompt);
			while (number < lowLim || number > highLim) { // infinte loop!
            Console.WriteLine("{0} is out of range!", number);
            // number = UIF.PromptInt(longPrompt); //OMITS repeated prompt!
         }
         return number;
      }                                                     // past new chunk
   }                                          
}

