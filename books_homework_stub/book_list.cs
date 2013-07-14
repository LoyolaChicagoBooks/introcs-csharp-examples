using System;
using System.IO;
using System.Collections.Generic;
// Names:

namespace IntroCS
{
   /// A class that maintains a list of books. 
   public class BookList
   {
      private List<Book> list;

      /// Create an empty list of books. 
      public BookList()
      {
         list = new List<Book>();
      }
                                                      //AddBook chunk
      // Add book to the list.
      // The regular assignment version always returns true. 
      public bool Addbook(Book book)
      {   // code

         return true; //always true in basic assignment
      }
                                                      //PrintList chunk
      /// List the full descriptions of each book,
      /// with each book separated by a blank line. 
      public void PrintList() // 
      {  // everyone code;    for extra credit, note assignment instructions

      }
                                             //PrintTitlesByAuthor chunk
      // List the titles (only!), one per line, of each book 
      // in the list that is by the specified author. 
      public void PrintTitlesByAuthor(string author)
      {  //code

      }
                                                //PrintBooksInYears chunk
     // List the full descriptions of each book printed
      // in the range of years specified,
      // with each book separated by a blank line. 
      public void PrintBooksInYears(int firstYear, int lastYear)
      {  // code

      }

      ////////////////////////////
      // Extra Credit past here //
      ////////////////////////////
                                                // extra credit ToString chunk
      /// Return a single string containing the same data as 
      /// printed by PrintList, including a final newline.
      public override string ToString()
      {
         return "Extra Credit ToString method not implemented.";
      }
                                                // extra credit BookList chunk
      // Construct a new BookList using Book data read from
      // reader.  The data coming from reader will contain groups
      // of three line descriptions useful for the Book constructor
      // that reads from a stream.  Each three-line book description
      // *may or may not* be preceded by an empty line. 
      public BookList(StreamReader reader)
      { // code for extra credit

      }
                                                // extra credit Contains chunk
      // Test if aBook is contained in this BookList.
      // Return true if book IsEqual to a Book in the list,
      // false otherwise. 
      public bool Contains(Book book)
      { // code for extra credit

         return true;  //so stub compiles
      }
                                                // extra credit AddAll chunk
      // Add each Book in books to this BookList.
      // if it is not already contained in this BookList.
      // Return true if the current list was changed.
      // Return false if each Book in books is a
      // duplicate of a Book in the current list. 
      public bool AddAll(BookList books)
      { // code for extra credit

         return true;  // so stub compiles
      }

     // Revised AddBook documentation for extra credit:
     
     /// Adds aBook to the list if aBook is
     /// not already in the list.
     /// Return true if aBook is added,
     /// and false if it was already in the list. 
   }
}