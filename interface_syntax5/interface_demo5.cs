class InterfaceDemo5 : abc  
{
   public static void Main()
   {
      System.Console.WriteLine("Hello Interfaces");
      InterfaceDemo5 refDemo = new InterfaceDemo5();
      refDemo.xyz();
      Sample refSample = new Sample();
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
Now a second class, Sample, implementing interface abc is added,
and we can create objects of both classes:

refDemo is a reference to the object of class InterfaceDemo5. 
refSample is a reference to the object of class Sample. 

Both the classes implement the interface abc, with their own separate 
implementation of the function xyz(). 
Functions xyz() of the respective classes InterfaceDemo5 and 
Sample are invoked through references refDemo and refSample.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/