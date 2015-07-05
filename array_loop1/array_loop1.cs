using System;

class ArrayLoop1
{  //Play computer on this code and then test
   public static void Main()
   {
      int[] a = {1, 2, 3}, b = {7, 2, 3, 5},
            c = {7, 0, 3, 2, 5};
      Console.WriteLine(foo(a, b, 2));
      Console.WriteLine(foo(c, b, 4));
   }

   static int foo(int[] x, int[] y, int n)
   {
      int k = 0;
      for (int i = 0; i < n; i++)
         if (x[i] == y[i]) {
            k++;
         }
      return k;
   }
}
