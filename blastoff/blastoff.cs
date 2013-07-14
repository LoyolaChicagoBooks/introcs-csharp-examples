using System;

class Blastoff
{
   static void Main()
   {
      int time = 10;
      while (time > 0) {
         Console.WriteLine(time);
         time = time - 1;
      }
      Console.WriteLine("Blastoff!");
   }
}


