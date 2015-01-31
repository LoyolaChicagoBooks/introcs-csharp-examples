class InterfaceDemo1
{
   public static void Main()
   {
      System.Console.WriteLine("Hello Interfaces");
   }
}

interface abc
{
//   int x;  /* run commented out, then try uncommented */
}

/* -------------------------------------------------------
The above program consists of a class InterfaceDemo1 and
an interface abc.   Main()  prints 
Hello Interfaces
Interface abc is empty at this point of time. 
Let's add some elements to this interface:

Uncommenting the line with 
//    int x;
gives a compiler error - 
since an interface cannot have any fields defined.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/
