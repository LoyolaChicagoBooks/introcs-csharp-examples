using System;

namespace IntroCS
{
   public class TryUIFNT
   {
      public static void Main()
      {
         var i = UIFNT.PromptInt("Gimme an integer: ");
         Console.WriteLine("Thank you for entering " + i);
         var d = UIFNT.PromptDecimal("Gimme a decimal: ");
         Console.WriteLine("Thank you for entering " + d);
      }
   }
}

