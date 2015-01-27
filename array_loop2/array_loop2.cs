using System;

class ArrayLoop2
{  //Play computer on this code first and then test
   public static void Main() 
   {
      int[] a =  {5, 7, 6, 9, 8};          
      for (int i = 0; i < 3; i++) {         
         a[i+2] = a[i];            
      }
      foreach (int x in a) {   
         Console.Write(x);
      }
      Console.WriteLine();
   }
}
