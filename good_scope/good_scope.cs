using System;

class GoodScope
{
   static void Main()
   {
      int x = 3;
      F(x);
   }
   static void F(int x)
   {
      Console.WriteLine(x);
   }

}

