using System;

namespace IntroCS
{
   public class Searching
   {
                                    // chunk-linearsearch-begin
      /// Return the index of the first position in data
      /// where item appears, or -1 if item does not appear.
      public static int IntArrayLinearSearch(int[] data, int item) 
      {
         int N=data.Length;
         for (int i=0; i < N; i++) {
            if (data[i] == item) {
               return i;
            }
         }
         return -1;
      }
                                    // chunk-linearsearchfrom-begin
      /// Return the first index >= start in data where
      /// item appears, or -1 if item does not appear there.
      public static int IntArrayLinearSearch(int[] data, int item, 
                                             int start) 
      {
         int N=data.Length;
         if (start < 0) {
            return -1;
         }
         for (int i=start; i < N; i++) {
            if (data[i] == item) {
               return i;
            }
         }
         return -1;
      }
                                             // chunk-driver-begin
      public static void Main()
      {        
         string input = UI.PromptLine(
            "Please enter some integers, separated by single spaces: ");
         int[] data = IntsFromString(input);
         for (int i=0; i < data.Length; i++) {
            Console.WriteLine("data[{0}]={1}", i, data[i]);
         }
         string prompt = 
              "Please enter a number you want to find (blank line to end): ";
         input = UI.PromptLine(prompt);
         while (input.Length > 0) {
            int searchItem = int.Parse(input);
            int searchPos = UI.PromptInt(
              "At what position should the search start (0 for beginning): ");
            int foundPos = IntArrayLinearSearch(data, searchItem, searchPos);
            if (foundPos < 0) {
               Console.WriteLine("Item {0} not found", searchItem);
            } 
            else {
               Console.WriteLine("Item {0} found at position {1}", 
                                 searchItem, foundPos);
            }
            input = UI.PromptLine(prompt);
         }
      }     
                                         // IntsFromString chunk      
      /// Return ints taken from space separated integers in a string.
      public static int[] IntsFromString(string input)
      {
         string[] integers = input.Split(' ');
         int[] data = new int[integers.Length];
         for (int i=0; i < data.Length; i++)
            data[i] = int.Parse(integers[i]);
         return data;
      }
   }                                     // end chunk
}
