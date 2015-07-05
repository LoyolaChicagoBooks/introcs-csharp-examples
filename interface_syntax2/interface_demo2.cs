class InterfaceDemo2
{
   public static void Main()
   {
      System.Console.WriteLine("Hello Interfaces");
   }
}

interface abc
{
   void xyz();

//   void xyzBad() /* run commented, then try 4 lines uncommented */
//   {
//      System.Console.WriteLine("In xyz");
//   }
}

/* -------------------------------------------------------
The version above. commenting out 4 lines, defines an unused,
but legal interface containing a method heading and semicolon.
The semicolon appears *instead* of a body.

Uncommenting the 4 lines defining method xyzBad gives a compiler
error since an interface method heading cannot have a body
defined with it.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/
