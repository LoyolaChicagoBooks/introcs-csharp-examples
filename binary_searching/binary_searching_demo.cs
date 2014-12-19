using System;

namespace IntroCS
{
   public class BinarySearchingDemo
   {
      public static void Main()
      {                                  // driver chunk
         string input = UI.PromptLine(
            "Please enter some comma/space separated integers: ");
         int[] data = ExtractFromString.IntsFromString(input);
         Sorting.IntArrayShellSortBetter(data);
         string prompt =
            "Please enter a number to find (empty line to end): ";
         input = UI.PromptLine(prompt);
         while (input.Length != 0) {
            int searchItem = int.Parse(input);
            int foundPos = BinarySearching.IntArrayBinarySearchPrinted(
                                                    data, searchItem);
            if (foundPos < 0)
               Console.WriteLine("Item {0} not found", searchItem);
            else
               Console.WriteLine("Item {0} found at position {1}", 
                  searchItem, foundPos);
            input = UI.PromptLine(prompt);
         }
      }                                 // end drive chunk
   }
}

