using System;

namespace IntroCS
{
   class OkIfScope
   {
      static void Main()
      {
         Console.WriteLine(OkScope(5));
         Console.WriteLine(OkScope2(5));
      }
                                  // ok chunk
      static int OkScope(int x) 
      {
         int val;  
         if (x < 100) {
            val = x + 2;
         }
         else {
            val = x - 2;
         }
         return val;
      }
                                  // past chunk
      static int OkScope2(int x) 
      {
         // without the = 0: Unassigned local variable error
         int val = 0;  
         if (x < 100) {
            val = x + 2;
         }
         if (x >= 100) {
            val = x - 2;
         }
         return val;
      }
                                   // past chunk
   }
}
