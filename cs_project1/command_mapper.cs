using System;
using System.Collections.Generic;
namespace IntroCS
{
   
   /// Note all commands (This class will be changed). 
   public class CommandMapper
   {
      private static string[] commands = {"help", "go", "quit"};

      public static string GetAllCommands() {
         string ret = "";
         foreach (string c in commands) {
            ret += c + " ";
         }
         return ret;
      }

      /// Check whether aString is a valid command word. 
      /// Return true if it is, false if it isn't.
      public static bool isCommand(string aString)
      {
         foreach (string s in commands) {
            if (s == aString) {
               return true;
            }
         }
         return false;
      }
   }
}
