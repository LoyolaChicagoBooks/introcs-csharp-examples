using System;
using System.Text;
using System.Text.RegularExpressions;

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
         }
         Console.WriteLine("Parsing " + digits.ToString());
         return int.Parse(digits.ToString());
      }

      public static int PromptInt(string prompt)
      {

         var digits = new StringBuilder(10, 100);

         // by flexible, I mean: What allows us to keep collecting sign and digits and still be valid?
         // This allows + and - to be valid as long as we're still making progress toward an integer.
         // Problem: May not get enough digits for int.Parse() to work.
         var flexIntSyntax = new Regex(@"^[\+-]?\d*$");

         // intParseSyntax enforces that there is at least one digit. If we required this in the loop,
         // we couldn't incrementally build up the integer one character at a time, because + or - on its
         // own would not be valid

         var intParseSyntax = new Regex(@"^[\+-]?\d+$");
         Console.Write(prompt);
         // read digits only 
         while (true) {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) {
               if (intParseSyntax.IsMatch(digits.ToString()))
                  break;
            }
            else if (key.Key == ConsoleKey.Backspace) {
               if (digits.Length > 0) {
                  digits.Remove(digits.Length - 1, 1);
                  Console.Write("\b");
               }
            }
            else {
               digits.Append(key.KeyChar);
               if (flexIntSyntax.IsMatch(digits.ToString())) 
                  Console.Write(key.KeyChar);
               else
                  digits.Remove(digits.Length - 1, 1);
            } 
         }

         return int.Parse(digits.ToString());
      }
   }
}

