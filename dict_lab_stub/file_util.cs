using System;
using System.IO;
using System.Collections.Generic;

namespace IntroCS
{
   public class FileUtil
   {                                          // start ReadParagraph chunk
      /// Return a string consisting of a sequence of nonempty lines read
      /// from reader. All the newlines at the ends of these lines are included.
      /// The function ends after reading (but not including) an empty line.
      public static string ReadParagraph(StreamReader reader)
      {                                       // end heading chunk

         // REPLACE the next line with your lines of code
         return "You have not coded ReadParagraph yet!\n";
      }
                                         // start GetParagraphs chunk
      /// Read the remaining empty-line terminated paragraphs
      /// from reader into a new list of paragraph strings,
      /// and return the list.
      /// The function reads all the way to the end of
      /// the file attached to reader.
      /// The file must end with two newlines in sequence: one at the
      /// end of the last nonempty line followed by one for the empty line.
      public static List<string> GetParagraphs(StreamReader reader)
      {
         List<string> all = new List<string>();

         // REPLACE the next line with your lines of code to fill all
         all.Add("You have not coded GetParagraphs yet!\n");

         return all;
      }
                                         // start  GetDictionary chunk
      /// Return a new Dictionary, taking data for it from reader.
      /// Reader contains key-value pairs, where each single-line key is
      /// followed by a possibly multi-line paragraph value that is terminated
      /// by an empty line. The file must end with two newlines in sequence:
      /// one at the end of the last nonempty line followed by one for the
      /// empty line.
      public static Dictionary<string, string> GetDictionary(StreamReader reader)
      {
         Dictionary<string, string> d = new Dictionary<string, string>();

         // add your lines of code to fill d here!

         return d;
      }
                                          // end GetDictionary chunk
 
      //Altered Extra credit documentation for GetDictionary:
      /// Return a new Dictionary, taking data for it from reader.
      /// Reader generates key-value pairs, where one or more space
      /// separated keys on a line are followed by a possibly multi-line
      /// paragraph value that is terminated by an empty line.  Each
      /// key on the line is mapped to the same paragraph that follows.
      /// The file must end with two newlines in sequence:  one at the end
      /// of the last nonempty line followed by one for the empty line.
   }
}

