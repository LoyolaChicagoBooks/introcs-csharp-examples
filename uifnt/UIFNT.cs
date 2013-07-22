using System;
using System.Text;

namespace uifnt
{
   public class UIFNT
   {
      public static int PromptUnsignedInt(string prompt)
      {

         var digits = new StringBuilder(10, 100);
         Console.Write(prompt);
         // read digits only 
         while (true) {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
               break;

            if (key.Key == ConsoleKey.Backspace && digits.Length > 0) {
                  digits.Remove(digits.Length - 1, 1);
                  Console.Write("\b");
            }

            if (key.KeyChar >= '0' && key.KeyChar <= '9') {
               Console.Write(key.KeyChar);
               digits.Append(key.KeyChar);
            }
         }; 
         Console.WriteLine("Parsing " + digits.ToString());
         return int.Parse(digits.ToString());
      }
   }
}

