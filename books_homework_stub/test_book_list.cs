using System;
using System.IO;
using System.Collections.Generic;
// Names:

namespace IntroCS
{
   /// A main program to test the class BookList. 
   class TestBookList
   {
       /// Test BookList.
       public static void Main()
       {
           BookList books = new BookList();
           // ...
           books.Addbook(new Book("C# Yellow Book", "Rob Miles", 2011));
           // Add more!
           // ...
           Console.WriteLine("The full list is:");
           books.PrintList();
           // Add more tests to fully test your code.
           // Make sure the correctness of the tests can be seen without reading
           // the source code -- comment on the meanings.
           // ...
       }
   }
}
