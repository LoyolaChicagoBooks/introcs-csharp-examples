using System;

class SignArray1
{  
   public static void Main() 
   {
      int[] a = {-7, 2, 3, 0, -22};  
      int[] s = Signs1(a);
      for(int i=0; i < a.Length; i++) {
         Console.WriteLine(a[i] + " " + s[i]);
      }
   }
   //                             heading chunk
   /// Return an array contqining the sign (1, -1 or 0)
   /// of each element of x.
   /// For example if x contains elements 2, -5, 0, 7,
   /// then return a new array containing 1, -1, 0, 1.
   static int[] Signs1(int[] x) 
   {                          // end heading chunk
      int[] sign = new int[x.Length];
      for (int i = 0; i < x.Length; i++) {
         if (x [i] > 0) {
            sign [i] = 1;
         } else if (x [i] < 0) {
            sign [i] = -1;
         } else {
            sign [i] = 0;
         }
      }
      return sign;
   }
}
