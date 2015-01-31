class InterfaceDemo4 : abc  
{  // finally actually using the interface!
   public static void Main()
   {
      System.Console.WriteLine("Hello Interfaces");
      InterfaceDemo4 demo = new InterfaceDemo4();
      demo.xyz();  
   }

   public void xyz()
   {
      System.Console.WriteLine("In xyz");
   }  
}

interface abc
{
   void xyz();
}

/*
Now we see the abc interface actually being used.

Run this to see a simple use of the interface method xyz.
Since xyz is an instance method, it must be bound to an object.  
With no declared constructor in class InterfaceDemo4,
we can still use an implicit empty constructor created by the compiler.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/