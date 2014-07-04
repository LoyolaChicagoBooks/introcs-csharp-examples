using System;

class PowerTable
{

   static void Main()
   {                                         // start chunk
      Console.WriteLine("{0,2}{1,7}{2,5}{3,7}",
                        "n", "square", "cube", "root");
      for ( int n = 1; n <= 10; n++) {
         Console.WriteLine("{0,2}{1,7}{2,5}{3,7:F4}",
                           n, n*n, n*n*n, Math.Sqrt(n));
      }
   }                                        // end chunk
}                                          


