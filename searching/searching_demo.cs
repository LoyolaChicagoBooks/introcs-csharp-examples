using System;

namespace IntroCS
{
   public class SearchingDemo
   {
      public static void Main()
      {  // demo chunk
         string input = UI.PromptLine(
            "Please enter integers, separated by spaces and/or comma: ");
         int[] data = ExtractFromString.IntsFromString(input);
         for (int i=0; i < data.Length; i++) {
            Console.WriteLine("data[{0}]={1}", i, data[i]);
         }
         string prompt =
            "Please enter a number to find (blank line to end): ";
         input = UI.PromptLine(prompt);
         while (input.Length > 0) {
            int searchItem = int.Parse(input);
            int searchPos = UI.PromptIntInRange(
                               "At what position should the search start? ",
                               0, data.Length);
            int foundPos =
               Searching.IntArrayLinearSearch(data,searchItem, searchPos);
            if (foundPos < 0) {
               Console.WriteLine("Item {0} not found", searchItem);
            }
            else {
               Console.WriteLine("Item {0} found at position {1}",
                                 searchItem, foundPos);
            }
            input = UI.PromptLine(prompt);
         }
      }                                       // end demo chunk
   }
}

