using System;
using System.Text;
using System.Text.RegularExpressions;

namespace uifnt
{
   public class UIFNT
   {
      public static Regex intAccept = new Regex(@"^[\+-]?\d*$");

      /*
       * Explanation of validation regex for integers
       * 
       *    ^           match beginning of string (the candidate number)
       *    [\+-]       optional sign
       *    \d+         match 1 or more digits (\d); note that the 1st parameter uses \d* to allow zero or more until we build the full string
       *    $           match the end of string (to make sure there is no extraneous input)
       */

      public static Regex intValidate = new Regex(@"^[\+-]?\d+$");
      public static Regex digitsAccept = new Regex(@"^\d*$");
      public static Regex digitsValidate = new Regex(@"^\d+$");
      public static Regex decimalAccept = new Regex(@"^[\+-]?\d*(\.)?\d*$");

      /*
       * Explanation of validation regex for decimals
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

      public static Regex decimalValidate = new Regex(@"^[\+-]?((\d*(\.)?\d+)|(\d+(\.)?\d*))$");
      public static Regex doubleAccept = new Regex(@"^([\+-]?\d*(\.\d*)?|[\+-]?(\d+\.)\d*)((\d\.|\d)[eE][\+-]?\d*)?$");
      public static Regex doubleValidate = new Regex(@"^([\+-]?\d+(\.\d*)?|[\+-]?\.\d+)([eE][\+-]?\d+)?$");

      public static string PromptLine(string prompt)
      {
         Console.Write(prompt);
         return Console.ReadLine();
      }

      private static String AcceptInput(Regex accept, Regex validate) {
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


      public static int PromptUnsignedInt(string prompt)
      {
         Console.Write(prompt);
         return int.Parse(AcceptInput(digitsAccept, digitsValidate));
      }


      public static int PromptInt(string prompt)
      {
         Console.Write(prompt);
         return int.Parse(AcceptInput(intAccept, intValidate));
      }

      public static decimal PromptDecimal(string prompt) {
         Console.Write(prompt);
         return decimal.Parse(AcceptInput(decimalAccept, decimalValidate));
      }

      public static double PromptDouble(string prompt) {
         Console.Write(prompt);
         return double.Parse(AcceptInput(doubleAccept, doubleValidate));
      }

      public static int PromptIntInRange(string prompt, 
                                         int lowLim, int highLim)
      {
         string longPrompt = string.Format("{0} ({1} through {2}) ",
                                           prompt, lowLim, highLim);
         int number = PromptInt(longPrompt);
         while (number < lowLim || number > highLim) {
            Console.WriteLine("{0} is out of range!", number);
            number = PromptInt(longPrompt);
         }
         return number;
      }

      public static double PromptDoubleInRange(string prompt, 
                                               double lowLim, double highLim)
      {
         string longPrompt = string.Format("{0} ({1} through {2}) ",
                                           prompt, lowLim, highLim);
         double number = PromptDouble(longPrompt);
         while (number < lowLim || number > highLim) {
            Console.WriteLine("{0} is out of range!", number);
            number = PromptDouble(longPrompt);
         }
         return number;
      }

      public static bool Agree(string prompt)
      {
         Console.Write(prompt);
         // TODO: This can be ReadKey() as well and only terminates for Y/N/y/n (English).
         return "y" == Console.ReadLine();
      }
                                                     
      public static bool IsDigits(string s) {
         return digitsValidate.IsMatch(s);
      }
                                                     
      public static bool IsIntString(string s) {
         return intAccept.IsMatch(s);
      }
                                                     
      public static bool IsDecimalString(string s) {
         return decimalAccept.IsMatch(s);
      }

   }
}

