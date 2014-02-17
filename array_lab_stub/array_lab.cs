using System;

namespace IntroCS
{
   public class ArrayLab
   {
      public static void Main()
      { /// Include test:. Display test input and output 
        /// with liberal use of PrintInts,
        /// showing labeled inputs and outputs.

      }
                                                   //PrintInts chunk
      /// Print label and then each element preceeded by a space,
      ///  all across one line.  Example:
      ///  If a contains {3, -1, 5} and label is "Nums:",
      ///  print:   Nums: 3 -1 5                   
      static void PrintInts(string label, int[] a)
      {

      }
                                                   //ReadInts chunk
      ///  Prompt the user to enter n integers, and
      ///  return an array containing them.
      ///  Example:  ReadInts("Enter values", 3) could generate the
      ///  Console sequence:
      ///      Enter values (3)
      ///      1: 5
      ///      2: 7
      ///      3: -1
      ///  and the function would return an array containing {5, 7, -1}. 
      ///  Note the format of the prompts for individual elements.
      static int[] ReadInts(string prompt, int n)
      {
         return new int[0]; // so stub compiles
      }
                                                   //Minimum chunk
      ///  Return the minimum value in a.
      ///  Example: If a contains {5, 7, 4, 9}, return 4. 
      ///  Assume a contains at least one value.
      static int Minimum(int[] a)
      {
         return 0; // so stub compiles
      }
                                                   //CountEven chunk
      ///  Return the number of even values in a.
      ///  Example: If a contains {-4, 7, 6, 12, 9}, return 3. 
      static int CountEven(int[] a)
      {
         return 0; // so stub compiles
      }
                                                   //PairwiseAdd chunk
      ///  Add corresponding elements of a and b and place them in sum.
      ///  Assume all arrays have the same Length.
      ///  Example: If a contains {2, 4, 6} and b contains {7, -1, 8}
      ///  then at the end sum should contain {9, 3, 14}. 
      static void PairwiseAdd(int[] a, int[] b, int[] sum)
      {

      }
                                                   //NewPairwiseAdd chunk
      ///  Return a new array whose elements are the sums of the
      ///  corresponding elements of a and b.
      ///  Assume a and b have the same Length.
      ///  Example: If a contains {2, 4, 6} and b contains {3, -1, 5}
      ///  then return an array containing {5, 3, 11}. 
      static int[] NewPairwiseAdd(int[] a, int[] b)
      {
         return new int[0]; // so stub compiles
      }
                                                   //IsAscending chunk
      ///  Return true if the numbers are sorted in increasing order,
      ///  so that in each pair of consecutive entries,
      ///  the second is always at least as large as the first.
      ///  Return false otherwise.  Assume an array with fewer than
      ///  two elements is ascending.
      ///  Examples: If a contains {2, 5, 5, 8}, return true;
      ///  if a contains {2, 5, 3, 8}, return false. 
      static bool IsAscending(int[] a)
      {
         return false; // so stub compiles
      }
                                                   //PrintAscendingValues chunk
      ///  Print an ascending sequence from the elements
      ///  of a, starting with the first element and printing
      ///  the next number after the previous number
      ///  that is at least as large as the previous one printed.
      ///  Example: If a contains {5, 2, 8, 4, 8, 11, 6, 7, 10},
      ///  print:  5 8 8 11      
      static void PrintAscendingValues(int[] a)
      {

      }
                                                   //PrintRuns chunk
      ///  Prints each ascending run in a, one run per line.
      ///  Example: If a contains {2, 5, 8, 3, 9, 9, 8}, print
      ///  2 5 8
      ///  3 9 9
      ///  8          
      static void PrintRuns(int[] a)
      {

      }                                             
   }                                              // end PrintRuns chunk   
}
