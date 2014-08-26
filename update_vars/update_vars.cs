using System;

class UpdateVars
{
   static void Main()
   { // simple sequential code updating two variables
      int x = 3;     
      int y = x + 2;
      y = 2 * y;       
      x = y - x;      
      Console.WriteLine (x + " " + y);
   }
}