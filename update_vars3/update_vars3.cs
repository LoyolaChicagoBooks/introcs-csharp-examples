using System;

class UpdateVars3
{
   static void Main()
   { // another sequentail Playing Computer Exercise
      string s = "a";     
      string t = s + "n";
      s = t + s;       
      t = "b" + t;  
      s = t + s;
      Console.WriteLine (s + " " + t);
   }
}
