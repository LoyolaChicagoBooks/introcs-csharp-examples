using System;

namespace IntroCS
{
   public class RemoveZeros
   {  // nozeros chunk
      /// Return a new array with all the 0's that are in
      /// data removed.  If data contains 0, 3, 0, 0, 5, 9
      /// then an array containing 3, 5, 9 is returned.
      public static int[] NoZeros(int[] data)
      {
         int countNonZero = 0;
         foreach (int n in data) {  //find new length
            if (n != 0) {
               countNonZero++;
            }
         }
         int[] notzero = new int[countNonZero];
         int i = 0;  // index where to put the next value
         foreach(int n in data) {
            if (n != 0) { // copy non-zero elements
               notzero[i] = n;
               i++;
            }
         }
         return notzero;
      }
      ///main chunk
      public static void Main()
      {
         Console.WriteLine ("start:  0, 3, 0, 0, 5, 9, 0, 11");
         int[] nz = NoZeros (new[] { 0, 3, 0, 0, 5, 9, 0, 11});
         Console.WriteLine ("after removing 0's:");
         foreach (int x in nz) {
            Console.WriteLine (x);
         }
      }
   }
}
