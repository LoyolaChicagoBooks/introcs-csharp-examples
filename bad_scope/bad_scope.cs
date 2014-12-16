using System;

class BadScope
{
   public static void Main()
   {
      int x = 3;
      F();
   }

   static void F()  
   {  // F doesn't know about the x defined in Main
      //Console.WriteLine(x); //ERROR if uncommented
   }
}
