class InterfaceDemo6 : abc  
{
   public static void Main()
   {
      System.Console.WriteLine("Hello Interfaces");
      abc refDemo = new InterfaceDemo6(); // note declared type!
      refDemo.xyz();
      abc refSample = new Sample();   // note declared type!
      refSample.xyz();    
   }

   public void xyz()
   {
      System.Console.WriteLine("In Demo :: xyz");
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
Same effect as version 5. Only a change in *declared* type:
Note that kind of objects created are now different
than their common declared interface type:  abc.
We can still call any method declared in the interface.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/