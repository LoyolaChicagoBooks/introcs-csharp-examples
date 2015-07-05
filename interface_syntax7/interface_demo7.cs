class InterfaceDemo7 : abc
{
   public static void Main()
   {
      System.Console.WriteLine("Hello Interfaces");
      abc[] items = {new InterfaceDemo7(), new Sample()}; // compare types!
      foreach (abc element in items) {
         element.xyz ();
      }
   }

   public void xyz()
   {
      System.Console.WriteLine("In InterfaceDemo7 :: xyz");
   }
}

interface abc
{
   void xyz();
}

class Sample : abc
{
   public void xyz()
   {
      System.Console.WriteLine("In Sample :: xyz");
   }
}

/*
Same effect as version 6, but now we declare an array
with *interface* type.  We can place in it
data of different *class* types
that satisfy this same *interface* type.

Since the array is declared to have elements
of interface type abc, the foreach iteration variable,
element, is declared to be the same type: abc.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/