using System;

namespace IntroCS
{
   public class BinarySearching
   {                                     // chunk-binarysearch-begin
      /// Return the index of item in a non-empty sorted array data,
      /// or return -1 if item is not in the array.
      public static int IntArrayBinarySearch(int[] data, int item) 
      {
         int min = 0, max = data.Length-1;
         while(min <= max) {
            int mid = (min+max) / 2;
            if (data[mid] == item)
               return mid;
            if (item > data[mid])
               min = mid + 1;
            else
               max = mid - 1;
         } 
         return -1;
      }
                                          // chunk-binarysearch-end
      /// Print the part of data for indices in range [min,max]; 
      /// other spots are blank; works for up to 3 character numbers.
      public static void IntArrayPrint(int[] data, int min, int max) 
      {
         for (int i=0; i < data.Length; i++) {
            string number = "";
            if (i >= min && i <= max) {
               number = "" + data[i];
            }
            Console.Write("{0,4}", number); // 4 is column width
         }
         Console.WriteLine();
      }

      /// Return an array containing 0, 1, ....len-1.
      public static int[] IndexSeq(int len)
      {
         int[] seq = new int[len];
         for (int i = 0; i < len; i++)
            seq[i] = i;
         return seq;
      }

      /// Binary search with step by step display
      public static int IntArrayBinarySearchPrinted(int[] data, int item) 
      {
         int N=data.Length, min = 0, max= N-1;
         Console.WriteLine("array indices:");
         IntArrayPrint(IndexSeq(N), min, max);
         Console.WriteLine("array data:");
         while (min <= max) {
            IntArrayPrint(data, min, max);
            int mid = (min+max) / 2;
            Console.WriteLine("min={0} max={1} mid={2}", min, max, mid);
            if (data[mid] == item)
               return mid;
            if (item > data[mid])
               min = mid + 1;
            else
               max = mid - 1;
         } 
         return -1;
      }
   }                                   
}
