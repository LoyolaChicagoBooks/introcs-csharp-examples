using System;
 
namespace IntroCS
{
   public class Sorting
   {                               // chunk-exchange-begin
      /// Exchange the elements of data at indices m and n.
      public static void Exchange(int[] data, int m, int n)
      {
         int temporary = data[m];
         data [m] = data[n];
         data [n] = temporary;
      }
                                   // chunk-bubblesort-begin
      public static void IntArrayBubbleSort (int[] data)
      {
         int N = data.Length;
         for (int j=N-1; j>0; j--) {
            for (int i=0; i<j; i++) {
               if (data[i] > data[i + 1]) {
                  Exchange (data, i, i + 1);
               }
            }
         }
      }
                                 // chunk-insertionsort-begin
      public static void IntArrayInsertionSort (int[] data)
      {
         int N = data.Length;
         for (int j=1; j<N; j++) {
            for (int i=j; i>0 && data[i] < data[i-1]; i--) {
               Exchange (data, i, i - 1);
            }
         }
      }
                             // chunk-selectionsort-begin
      /// Among the indices >= start for data, 
      /// return the index of the minimal element.
      public static int IntArrayMin (int[] data, int start)
      {
         int N = data.Length, minPos = start; 
         for (int pos=start+1; pos < N; pos++)
         if (data[pos] < data[minPos]) {
               minPos = pos;
         }
         return minPos; 
      }

      public static void IntArraySelectionSort (int[] data)
      {
         int N = data.Length;
         for (int i=0; i < N-1; i++) {
            int k = IntArrayMin(data, i);
            if (i != k) {
               Exchange(data, i, k);
            }
         }
      }
                                          // chunk-shellsort-begin
      /// Shell sort of data using specified swapping intervals.
      public static void IntArrayShellSort (int[] data, int[] intervals)
      {
         int N = data.Length;
         // The intervals for the shell sort must be sorted, ascending
         for (int k=intervals.Length-1; k>=0; k--) {
            int interval = intervals[k];
            for (int m=0; m<interval; m++) {
               for (int j=m+interval; j<N; j+=interval) {
                  for (int i=j; i>=interval && data[i]<data[i-interval]; 
                       i-=interval) {
                     Exchange (data, i, i - interval);
                  }
               }
            }
         }
      }
                                       // chunk-shellsort-naive-begin
      public static void IntArrayShellSortNaive (int[] data)
      {
         int[] intervals = { 1, 2, 4, 8 };
         IntArrayShellSort (data, intervals);
      }
                                       // chunk-shellsort-better-begin 
      /// Generates the intervals for Shell sort on a  
      /// list of length n via an algorithm from Knuth.
      static int[] GenerateIntervals (int n)
      {
         if (n < 2) {  // no sorting will be needed
            return new int[0];
         }
         int t = Math.Max (1, (int)Math.Log (n, 3) - 1);
         int[] intervals = new int[t];       
         intervals [0] = 1;
         for (int i=1; i < t; i++)
            intervals [i] = 3 * intervals [i - 1] + 1;
         return intervals;
      }

      public static void IntArrayShellSortBetter (int[] data)
      {
         int[] intervals = GenerateIntervals (data.Length);
         IntArrayShellSort (data, intervals);
      }
                                    // chunk-quicksort-begin
      /// Sort elements of data in index range [lowI, highI].
      public static void IntArrayQuickSort (int[] data, 
                                            int lowI, int highI)
      {
         int afterSmall = lowI, beforeBig = highI;
         int pivot = data[(lowI + highI) / 2];  
         // in loop data[i] <= pivot if i < afterSmall
         //         data[i] >= pivot if i > beforeBig
         //         region with aftersmall <= i <= beforeBig
         //             shrinks to nothing.
         while (afterSmall <= beforeBig) {
            while (data[afterSmall] < pivot)
               afterSmall++;
            while (pivot < data[beforeBig])
               beforeBig--;
            if (afterSmall <= beforeBig) {
               Exchange (data, afterSmall, beforeBig);
               afterSmall++;
               beforeBig--;
            }
         }  // after loop: beforeBig < afterSmall, and
         //      data[i] <= pivot for i <= beforeBig, 
         //      data[i] == pivot for i if beforeBig < i < afterSmall, 
         //      data[i] >= pivot for i >= afterSmall. 
         if (lowI < beforeBig) // at least two elements
            IntArrayQuickSort (data, lowI, beforeBig);
         if (afterSmall < highI) // at least two elements
            IntArrayQuickSort (data, afterSmall, highI);
      }

      public static void IntArrayQuickSort (int[] data)
      {
         if (data.Length > 1)
            IntArrayQuickSort (data, 0, data.Length - 1);
      }
                                          // chunk-random-begin
      /// Fill data with pseudo-random data seeded by randomSeed.
      public static void IntArrayGenerate (int[] data, int randomSeed)
      {
         Random r = new Random (randomSeed);
         for (int i=0; i < data.Length; i++)
            data [i] = r.Next ();
      }
   }                                     // end chunk
}
