using System;
namespace IntroCS
{  
   /// Console input functions with prompts and safe parsing
   public class UI 
   {
      /// After displaying the prompt, return a line from the keyboard.
      public static string PromptLine(string prompt)
      {
         Console.Write(prompt);
         return Console.ReadLine();
      }

      /// Prompt the user to enter an integer until the response is legal.
      /// Return the result as in int. 
      public static int PromptInt(string prompt)
      {
         string nStr = PromptLine(prompt).Trim();
         while (!IsIntString(nStr)) {
            Console.WriteLine("Bad int format!  Try again.");
            nStr = PromptLine(prompt).Trim();
         }
         return int.Parse(nStr);
      }

      /// Prompt the user to enter a decimal value until the response 
      /// is legal.  Return the result as a double. 
      public static double PromptDouble(string prompt)
      {
         string nStr = PromptLine(prompt).Trim();
         while (!IsDecimalString(nStr)) {
            Console.WriteLine("Bad decimal format!  Try again.");
            nStr = PromptLine(prompt).Trim();
         }
         return double.Parse(nStr);
      }

      /// Prompt the user to enter a decimal value until the response 
      /// is legal.  Return the result as a decimal. 
      public static decimal PromptDecimal(string prompt)
      {
         string nStr = PromptLine(prompt).Trim();
         while (!IsDecimalString(nStr)) {
            Console.WriteLine("Bad decimal format!  Try again.");
            nStr = PromptLine(prompt).Trim();
         }
         return decimal.Parse(nStr);
      }

      /// Prompt the user until a keyboard entry is an int
      /// in the range [lowLim, highLim].  Then return the int value 
      /// in range.  Append the range to the prompt.
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

      /// Prompt the user until a keyboard entry is a decimal
      /// in the range [lowLim, highLim].  Then return the double 
      /// value in range.  Append the range to the prompt.
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

      /// Prompt the user with a question. 
      /// Force an understandable keyboard response;
      /// Return true of false based on the final response.  
      public static Boolean Agree(string question)
      {
         string meanYes = "ytYT", meanNo = "nfNF",
         validResponses = meanYes + meanNo;
         string answer = PromptLine(question);
         while (answer.Length == 0 ||
            !validResponses.Contains(""+answer[0])) {
            Console.WriteLine("Enter y or n!");
            answer = PromptLine(question);
         }
         return meanYes.Contains(""+answer[0]);
      }

      // helper string testing functions

      /// True when s consists of only 1 or more digits.
      public static bool IsDigits(string s)
      {
         foreach( char ch in s) {
            if (ch <'0' || ch > '9') {
               return false;
            }
         }
         return (s.Length > 0);
      }

      /// compare integer strings: 
      ///   any lengths, but both positive or both negative
      /// true if magnitude of s <= magnitude of lim
      public static bool IntStrMagLessEq(string s, string lim)
      {
         return s.Length < lim.Length || //automatically magnitude less
            s.Length == lim.Length && s.CompareTo(lim) <= 0;
      }     // for same length, lexicographical comparison works


      /// True if s is the string form of an int. 
      public static bool IsIntString(string s)
      {
         if (s.StartsWith("-")) {
            return IsDigits(s.Substring(1)) && 
               IntStrMagLessEq(s, "" + int.MinValue);
         }
         return IsDigits(s) && IntStrMagLessEq(s, "" + int.MaxValue);
      }

      /// Return true if s represents a decimal string. 
      public static bool IsDecimalString(string s)
      {
         if (s.StartsWith("-")) {
            s = s.Substring(1);
         }
         int i = s.IndexOf(".");
         if (i >= 0) { //dump found decimal point
            s = s.Substring(0,i) + s.Substring(i+1);
         }
         return IsDigits(s);
      }           
   }
}
