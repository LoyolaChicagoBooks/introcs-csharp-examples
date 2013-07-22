using System;

namespace uifnt
{
   public class TryUIFNT
   {
      public static void Main()
      {
         var n = UIFNT.PromptUnsignedInt("Gimme an unsigned: ");
         Console.WriteLine("Thank you for entering " + n);
      }
   }
}

