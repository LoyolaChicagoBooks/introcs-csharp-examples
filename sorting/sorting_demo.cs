using System;
using System.Diagnostics;

namespace IntroCS
{
   public class SortingDemo
   {  // chunk timing helpers
      /// Set up data and watch for sort timing
      public static void TimeSetup (int[] data, int randomSeed,
                                    Stopwatch watch)
      {
         Sorting.IntArrayGenerate (data, randomSeed);
         watch.Reset();
         watch.Start();
      }

      /// Report sort timing results from watch
      public static void TimeResult (string sortType, Stopwatch watch)
      {
         watch.Stop ();
         double elapsedTime = watch.ElapsedMilliseconds/1000.0;
         Console.WriteLine (sortType + ": {0:F3}", elapsedTime);
      }
      // chunk-setup-end
      /// Sorting timing tests allowing command line parameters
      /// for the size of the array and the random seed.
      /// If the arguments are not specified, the user is prompted.
      public static void Main (string[] args)
      {
         // chunk-drivervars-begin
         int arraySize;
         int randomSeed;
         Stopwatch watch = new Stopwatch ();
         int[] data;
         // chunk-driverparameters-begin
         if (args.Length < 2) {
            arraySize = UI.PromptInt("Please enter desired array size: ");
            randomSeed = UI.PromptInt(
                            "Please enter an initial random seed value: ");
         } else {
            arraySize = int.Parse (args [0]);
            randomSeed = int.Parse (args [1]);
         }
         data = new int[arraySize];
         // chunk-driverapparatus-begin
         TimeSetup(data, randomSeed, watch);
         Sorting.IntArrayQuickSort(data); //this line varies by experiment
         TimeResult("Quick Sort", watch);
         // chunk-driverapparatus-end
         TimeSetup(data, randomSeed, watch);
         Sorting.IntArrayShellSortNaive(data);
         TimeResult("Naive Shell Sort", watch);

         TimeSetup(data, randomSeed, watch);
         Sorting.IntArrayShellSortBetter (data);
         TimeResult("Better Shell Sort", watch);

         TimeSetup(data, randomSeed, watch);
         Sorting.IntArrayInsertionSort(data);
         TimeResult("Insertion Sort", watch);

         TimeSetup(data, randomSeed, watch);
         Sorting.IntArraySelectionSort(data);
         TimeResult("Selection Sort", watch);

         TimeSetup(data, randomSeed, watch);
         Sorting.IntArrayBubbleSort(data);
         TimeResult("Bubble Sort", watch);
      }
   }
}

