using System;
using System.Collections.Generic;
namespace IntroCS
{
   
   /// Help Response
   public class Helper
   {
      private Dictionary<string, string> details;

      /// Print out some Help information.
      /// Here we print some stupid, cryptic message and a list of the 
      /// command words.
      public bool Execute(Command cmd)
      {
         if (!cmd.hasSecondWord()) {
            Console.WriteLine(
@"You are lost. You are alone.
You wander around at the university.
                             
Your command words are:
   {0}

{1}", CommandMapper.GetAllCommands(), Help());
         }
         else if (details.ContainsKey(cmd.GetSecondWord())) {
            Console.WriteLine(details[cmd.GetSecondWord()]);
         }
         else {
            Console.WriteLine(
@"Unknown command {0}!  Command words are
    {1}", cmd.GetSecondWord(), CommandMapper.GetAllCommands());
         }
            return false;
      }

      public string Help()
      {
         return @"Enter
    help command
for help on the command.";
      }
           
      /// Constructor for objects of class Helper
      public Helper(Dictionary<string, string> details)
      {
         this.details = details;
      }
   }
}
