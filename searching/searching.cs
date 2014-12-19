using System;

namespace IntroCS
{
   public class Searching
   {                                 // chunk-linearsearch-begin                               
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
   }                               
}
