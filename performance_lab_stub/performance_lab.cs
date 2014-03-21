using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace IntroCS
{
   public class PerformanceLab
   {
      // chunk-experiment1-begin
      public static long ExperimentIntArrayLinearSearch (int n, int rep, int seed)
      {
         Stopwatch watch = new Stopwatch ();
         int[] data = new int[n];
         Sorting.IntArrayGenerate (data, seed);
         int m = Math.Max(1, n/rep);
         watch.Reset ();       
         watch.Start ();
         // perform the rep lookups
         for (int k=0, i=0; k < rep; k++, i=(i+m)%n) {
            Searching.IntArrayLinearSearch (data, data [i]);
         }
         watch.Stop ();
         return watch.ElapsedMilliseconds;
      }
      // chunk-experiment1-end
    
      public static long ExperimentIntArrayBinarySearch (int n, int rep, int seed)
      {
         Stopwatch watch = new Stopwatch ();
         int[] data = new int[n];
         Sorting.IntArrayGenerate (data, seed);
         // Use our existing work on sorting to generate sorted array for testing 
         Sorting.IntArrayQuickSort (data);
         int m = Math.Max(1, n/rep);
         watch.Reset ();       
         watch.Start ();
         // perform the rep lookups
         for (int k=0, i=0; k < rep; k++, i=(i+m)%n) {
            BinarySearching.IntArrayBinarySearch (data, data [i]);
         }
         watch.Stop ();
         return watch.ElapsedMilliseconds;
      }
          
      public static long ExperimentListSearch (int n, int rep, int seed)
      {
         Stopwatch watch = new Stopwatch ();
         int[] data = new int[n];
         Sorting.IntArrayGenerate (data, seed);
         List<int> dataAsList = new List<int> (data);
         int m = Math.Max(1, n/rep);
         watch.Reset ();       
         watch.Start ();
         // perform the rep lookups
         for (int k=0, i=0; k < rep; k++, i=(i+m)%n) {
            dataAsList.Contains(data [i]);
         }
         watch.Stop ();
         return watch.ElapsedMilliseconds;
      }

      public static long ExperimentSetSearch (int n, int rep, int seed)
      {
         var watch = new Stopwatch ();
         var data = new int[n];
         Sorting.IntArrayGenerate (data, seed);         
         var myset = new HashSet<int> (data);
         int m = Math.Max(1, n/rep);
         watch.Reset ();       
         watch.Start ();
         // perform the rep lookups
         for (int k=0, i=0; k < rep; k++, i=(i+m)%n) {
            myset.Contains(data [i]);
         }
         watch.Stop ();
         return watch.ElapsedMilliseconds;
      }
    
      public static void Main (string[] args)
      {
         int seed = new Random().Next();  // Use seed with each experiment.

         // Write the code to parse args for the parameters
         // rep n1 n2 n3 ...
       
         // Write the code to run each of the experiments for rep and
         // a value of n
       
         // Generate a comparative table for all values of n specified.
      }
   }
}
