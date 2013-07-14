using System;
using System.Diagnostics;
 
namespace IntroCS
{
   public class Sorting
   {
                                   // chunk-exchange-begin
      /// Exchange the elements of data at indices m and n.
      public static void Exchange(int[] data, int m, int n)
      {
         int temporary;

         temporary = data [m];
         data [m] = data [n];
         data [n] = temporary;
      }
                                   // chunk-bubblesort-begin
      public static void IntArrayBubbleSort (int[] data)
      {
         int i, j;
         int N = data.Length;

         for (j=N-1; j>0; j--) {
            for (i=0; i<j; i++) {
               if (data [i] > data [i + 1]) {
                  Exchange (data, i, i + 1);
               }
            }
         }
      }
                                 // chunk-insertionsort-begin
      public static void IntArrayInsertionSort (int[] data)
      {
         int i, j;
         int N = data.Length;

         for (j=1; j<N; j++) {
            for (i=j; i>0 && data[i] < data[i-1]; i--) {
               Exchange (data, i, i - 1);
            }
         }
      }
                             // chunk-selectionsort-begin
      /// Among the indices >= start for data, 
      /// return the index of the minimal element.
      public static int IntArrayMin (int[] data, int start)
      {
         int minPos = start; 
         for (int pos=start+1; pos < data.Length; pos++)
         if (data [pos] < data [minPos]) {
               minPos = pos;
         }
         return minPos; 
      }

      public static void IntArraySelectionSort (int[] data)
      {
         int i;
         int N = data.Length;

         for (i=0; i < N-1; i++) {
            int k = IntArrayMin (data, i);
            if (i != k) {
               Exchange (data, i, k);
            }
         }
      }
                                          // chunk-shellsort-begin
      /// Shell sort of data using specified swapping intervals.
      public static void IntArrayShellSort (int[] data, int[] intervals)
      {
         int i, j, k, m;
         int N = data.Length;

         // The intervals for the shell sort must be sorted, ascending
         for (k=intervals.Length-1; k>=0; k--) {
            int interval = intervals [k];
            for (m=0; m<interval; m++) {
               for (j=m+interval; j<N; j+=interval) {
                  for (i=j; i>=interval && data[i]<data[i-interval]; 
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
         while (true) {
            while (data[afterSmall] < pivot)
               afterSmall++;
            while (pivot < data[beforeBig])
               beforeBig--;
            if (afterSmall <= beforeBig) {
               Exchange (data, afterSmall, beforeBig);
               afterSmall++;
               beforeBig--;
            }
            if (afterSmall > beforeBig)
               break;
         }  // after loop:
         // data[i] <= pivot for i <= beforeBig, 
         // data[i] == pivot for i when beforeBig < i < afterSmall, 
         // data[i] >= pivot for i >= afterSmall, 
         if (lowI < beforeBig)
            IntArrayQuickSort (data, lowI, beforeBig);
         if (afterSmall < highI)
            IntArrayQuickSort (data, afterSmall, highI);
      }

      public static void IntArrayQuickSort (int[] data)
      {
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
                                          // chunk-random-end                                           
      /// Sorting timing tests allowing command line parameters
      /// for the size of the array and the random seed.
      /// If the arguments are not specified, the user is prompted.
      public static void Main (string[] args)
      {
                                          // chunk-drivervars-begin
         int arraySize;
         int randomSeed;
         Stopwatch watch = new Stopwatch ();
         double elapsedTime; // time in second, 
                             //  accurate to about millseconds
                                          // chunk-driverparameters-begin
         if (args.Length < 2) {
            arraySize = UI.PromptInt("Please enter desired array size: ");
            randomSeed = UI.PromptInt(
               "Please enter an initial random seed value: ");
         } else {
            arraySize = int.Parse (args [0]);
            randomSeed = int.Parse (args [1]);
         }
                                          // chunk-driverparameters-end
         int[] data = new int[arraySize];

         IntArrayGenerate (data, randomSeed);
         watch.Reset ();
         watch.Start ();
         IntArrayQuickSort (data);
         watch.Stop ();
         elapsedTime = watch.ElapsedMilliseconds/1000.0;
         Console.WriteLine ("Quick Sort: {0:F3}", elapsedTime);

         IntArrayGenerate (data, randomSeed);
         watch.Reset ();
         watch.Start ();
         IntArrayShellSortNaive (data);
         watch.Stop ();
         elapsedTime = watch.ElapsedMilliseconds/1000.0;
         Console.WriteLine ("Naive Shell Sort: {0:F3}", elapsedTime);

         IntArrayGenerate (data, randomSeed);
         watch.Reset ();
         watch.Start ();
         IntArrayShellSortBetter (data);
         watch.Stop ();
         elapsedTime = watch.ElapsedMilliseconds/1000.0;
         Console.WriteLine ("Better Shell Sort: {0:F3}", elapsedTime);

         IntArrayGenerate (data, randomSeed);
         watch.Reset ();
         watch.Start ();
         IntArrayInsertionSort (data);
         watch.Stop ();
         elapsedTime = watch.ElapsedMilliseconds/1000.0;
         Console.WriteLine ("Insertion Sort: {0:F3}", elapsedTime);

         IntArrayGenerate (data, randomSeed);
         watch.Reset (); 
         watch.Start ();
         IntArraySelectionSort (data);
         watch.Stop ();
         elapsedTime = watch.ElapsedMilliseconds/1000.0;
         Console.WriteLine ("Selection Sort: {0:F3}", elapsedTime);         
                                          // chunk-driverapparatus-begin
         IntArrayGenerate (data, randomSeed);
         watch.Reset ();
         watch.Start (); 
         IntArrayBubbleSort (data); // this line varies by experiment
         watch.Stop ();
         elapsedTime = watch.ElapsedMilliseconds/1000.0;
         Console.WriteLine ("Bubble Sort: {0:F3}", elapsedTime);                                            
      }                                   // chunk-driverapparatus-end
   }
}
