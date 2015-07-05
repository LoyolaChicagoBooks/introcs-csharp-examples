using System;

class SignArray2
{
   public static void Main()
   {
      int[] a = {-7, 2, 3, 0, -22};
      Console.WriteLine("Original data: ");
      foreach (int n in a) {
         Console.WriteLine(n);
      }
      Signs2(a);
      Console.WriteLine("After function call: ");
      foreach (int n in a) {
         Console.WriteLine(n);
      }
   }
   //                          heading chunk
   /// Mutate array x, replacing each element by
   /// its sign (1, -1 or 0)
   /// For example if array a contains elements  2, -5, 0, 7,
   /// then after the call Signs2(a), a contains 1, -1, 0, 1.
   static void Signs2(int[] x)
   {  // end of heading chunk
      for (int i = 0; i < x.Length; i++) {
         if (x [i] > 0) {
            x[i] = 1;
         } else if (x [i] < 0) {
            x[i] = -1;
         } else {
            x[i] = 0;
         }
      }
   }
}
