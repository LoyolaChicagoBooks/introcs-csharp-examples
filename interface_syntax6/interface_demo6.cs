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
      System.Console.WriteLine("In InterfaceDemo6 :: xyz");
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
Note that the objects created of classes InterfaceDemo6
and Sample are used to initialize variables
refDemo and refSample of their common interface type abc.
We can call any method declared in the interface.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/