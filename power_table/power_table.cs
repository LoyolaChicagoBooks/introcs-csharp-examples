using System;

class PowerTable
{

   static void Main()
   {                                         // start chunk
      Console.WriteLine("{0,2}{1,8}{2,8}{3,8}",
                        "n", "square", "cube", "root");
      for ( int n = 1; n <= 10; n++) {
         Console.WriteLine("{0,2}{1,8}{2,8}{3,8:F4}",
                           n, n*n, n*n*n, Math.Sqrt(n));
      }
   }                                        // end chunk
}                                          


