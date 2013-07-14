using System;
namespace IntroCS
{
   /// This class holds information about a command that was issued by the user.
   /// A command currently consists of two strings: a command word and a second
   /// word (for example, if the command was "take map", then the two strings
   /// obviously are "take" and "map").
   /// If the command had only one word, then the second word is <null>.
   /// modified from  Michael Kolling and David J. Barnes
   public class Command
   {
      public string CommandWord {get; private set;}
      public string SecondWord {get; private set;}
   
      public static Command getCommand()
      {
         string cmd;
         string parameter = null;
         string line = UI.PromptLine("> ").Trim();

         int i = line.IndexOf(" ");
         if (i == -1) {
            cmd = line;      // get first word
         }
         else {
            cmd = line.Substring(0, i);
            parameter = line.Substring(i).Trim();
         }
         return new Command(cmd, parameter);
      }

      /// Create a command object. First and second word must be supplied, but
      /// either one (or both) can be null.
      public Command(string firstWord, string secondWord)
      {
         CommandWord = firstWord;
         SecondWord = secondWord;
      }
      
      /// Return true if the command has a second word.
      public bool hasSecondWord()
      {
         return (SecondWord != null);
      }
   }
}
