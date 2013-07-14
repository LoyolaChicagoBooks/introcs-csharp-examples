using System;

class Return1
{
   static int F(int x)
   {
       return x*x;
   }

   static void Main()
   {
      Console.WriteLine(F(3));
      Console.WriteLine(F(3) + F(4));
   }
}

