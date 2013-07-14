using System;
using System.Collections.Generic;
namespace IntroCS
{
   
   /// Help Response
   public class Helper : Response
   {
      public string CommandName {get; private set;}
      private CommandMapper commandMapper;
      private Dictionary<string, Response> responses;

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

{1}", commandMapper.AllCommands, Help());
         }
         else if (responses.ContainsKey(cmd.SecondWord)) {
            Console.WriteLine(responses[cmd.SecondWord].Help());
         }
         else {
            Console.WriteLine(
@"Unknown command {0}!  Command words are
    {1}", cmd.SecondWord, commandMapper.AllCommands);
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
      public Helper(Dictionary<string, Response> responses,
                    CommandMapper commandMapper)
      {
         this.responses = responses;
         this.commandMapper = commandMapper;
         CommandName = "help";
      }
   }
}
