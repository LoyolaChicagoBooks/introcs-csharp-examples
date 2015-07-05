using System;

class ArrayLoop3
{  //Play computer on this code first and then test
   public static void Main()
   {
      string[] strArray = {"abcdefgh", "wxyz"};
      for (int i = 2; i < 4; i++) {
         foreach(string s in strArray) {
            Console.Write(s.Substring(s.Length/i) + "/");
         }
         Console.WriteLine();
      }
   }
}
