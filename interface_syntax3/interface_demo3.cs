class InterfaceDemo3 : abc  //: abc *says* that 
{                           //    abc interface will be implemented
   public static void Main()
   {
      System.Console.WriteLine("Hello Interfaces");
   }

   public void xyz()           // try removing public
   {
      System.Console.WriteLine("In xyz");
   }                   
}

interface abc
{
   void xyz();
}
/* -------------------------------------------------------
The full version above defines *how* to implement 
interface abc, though it still does not use its implementation.

Next remove just the word public from the declaration in line 8
changing
    public void xyz()
to
    void xyz()
    
That causes a compiler error:
interface method implementations must be public.

Inside the interface definition in line 16,
   void xyz();
no public is needed, because interface components are 
always assumed to be public: the "public" is implicit,
unlike in a class definition.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/
