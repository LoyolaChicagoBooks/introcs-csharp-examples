using System;
using System.IO;

namespace IntroCS
{
   /// File I/O functions to help find files and folders
   /// when they may be in more than one path.
   public class FIO
   {
      private static string[] paths = { ".", "..", Path.Combine("..", "..") };

                                         // GetLocation chunk
      /// Return a directory conaining the filename, if it exists. 
      /// Otherwise return null.
      public static string GetLocation(string filename)
      {                                  // body chunk
         foreach (string dir in paths) {
            string filePath = Path.Combine(dir, filename);
            if (File.Exists(filePath))
               return dir;
         }
         return null;
      }
                                       // GetPath chunk
      /// Find a directory containing the filename
      /// and return the full file path, if it exists. 
      /// Otherwise return null.
      public static string GetPath(string filename)
      {
         foreach (string dir in paths) {
            string filePath = Path.Combine(dir, filename);
            if (File.Exists(filePath))
               return filePath;
         }
         return null;
      }
                                      //OpenReader chunk
      /// Find a directory containing filename;
      /// return a new StreamReader to the file
      /// or null if the file does not exist.
      public static StreamReader OpenReader(string filename) 
      {                                
         string filePath = GetPath(filename);
         if (filePath == null)
            return null;
         else
            return new StreamReader( filePath);
      }
                                             //OpenReader2 chunk
      /// Join the location directory and filename;
      /// return a new StreamReader to the file
      /// or null if the file does not exist.
      public static StreamReader OpenReader(string location, string filename) 
      {                                
         string filePath = Path.Combine(location, filename);
         if (File.Exists(filePath))
            return new StreamReader(filePath);
         else
            return null;
      }
                                             // OpenWriter chunk     
      /// Join the location directory and filename;
      /// open and return a StreamWriter to the file. 
      public static StreamWriter OpenWriter(string location, string filename) 
      {           
         string filePath = Path.Combine(location, filename);
         return new StreamWriter(filePath);
      }
   }                                        //end OpenWriter chunk                                      
}    

