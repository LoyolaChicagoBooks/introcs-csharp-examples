using System;

namespace uifnt
{
   public class TryUIFNT
   {
      public static void Main()
      {
         var n = UIFNT.PromptInt("Gimme an integer: ");
         Console.WriteLine("Thank you for entering " + n);
      }
   }
}

