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

      public static String AcceptInput(Regex accept, Regex validate) {
         var inputChars = new StringBuilder(10, 100);
         while (true) {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) {
               if (validate.IsMatch(inputChars.ToString()))
                  break;
            }
            else if (key.Key == ConsoleKey.Backspace) {
               if (inputChars.Length > 0) {
                  inputChars.Remove(inputChars.Length - 1, 1);
                  Console.Write("\b \b");
               }
            }
            else {
               inputChars.Append(key.KeyChar);
               if (accept.IsMatch(inputChars.ToString())) 
                  Console.Write(key.KeyChar);
               else
                  inputChars.Remove(inputChars.Length - 1, 1);
            } 
         }
         return inputChars.ToString();
      }

      public static int PromptInt(string prompt)
      {
         Console.Write(prompt);
         /*
          * Explanation of validation Regex (2nd parameter)
          *    ^           match beginning of string (the candidate number)
          *    [\+-]?      match + or - at the beginning of string (+ is part of Regex syntax, hence the escape 
          *    \d+         match 1 or more digits (\d); note that the 1st parameter uses \d* to allow zero or more until we build the full string
          *    $           match the end of string (to make sure there is no extraneous input)
          */

         return int.Parse(AcceptInput(new Regex(@"^[\+-]?\d*$"), new Regex(@"^[\+-]?\d+$")));
      }

      public static decimal PromptDecimal(string prompt) {
         Console.Write(prompt);
         /*
          * Explanation of validation Regex (2nd parameter)
          *    ^
          *    [\+-]?              similar to integer; allow + or - at beginning only
          *    (                   we use grouping to ensure one of the following apply
          *      ((\d*(\.)?\d+))   either there is a positive number of digits after an optional decimal point
          *      |                    - or -
          *      (\d+(\.)?\d*)     there is a positive number of digits before the optional decimal point
          *    )
          *    $                   end of string
          * 
          *    Note: If the decimal point is missing, this is ok;
          *    it means that the expression \d+\d* or \d*\d+ is being tested (to ensure a positive number of digits overall!
          */
         return decimal.Parse(AcceptInput(new Regex(@"^[\+-]?\d*(\.)?\d*$"), new Regex(@"^[\+-]?((\d*(\.)?\d+)|(\d+(\.)?\d*))$")));
      }
   }
}

