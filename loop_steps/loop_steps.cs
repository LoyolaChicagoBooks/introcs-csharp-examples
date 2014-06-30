using System;

class LoopSteps
{
   static void Main()
   { // play computer and predict what this loop does
      string s = "abcd";
      int i = 1;
      while (i < 4) {
         Console.Write ("/" + s[i] + s[i - 1]);
         i++;
      }
      Console.WriteLine();
   }
}