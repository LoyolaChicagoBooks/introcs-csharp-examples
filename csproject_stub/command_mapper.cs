using System;
using System.Collections.Generic;
namespace IntroCS
{
   
   /// Map commands names to commands.
   public class CommandMapper
   {
      public string AllCommands {get; private set;}
      private Dictionary<string, Response> responses; //responses to commands
       
      /// Initialize the command response mapping
      ///  game The game being played.
      public CommandMapper(Game game)
      {
         responses = new Dictionary<string, Response>();
         Response[] resp = {
            new Quitter(),
            new Goer(game),
            new Helper(responses, this)
            // add new Responses here!
         };
         AllCommands = "";
         foreach (Response r in resp) {
            responses[r.CommandName] = r;
            AllCommands += r.CommandName + " ";
         }
      }
   
      /// Check whether aString is a valid command word. 
      /// Return true if it is, false if it isn't.
      public bool isCommand(string aString)
      {
         return responses.ContainsKey(aString);
      }
   
      /// Return the command associated with a command word.
      ///  cmdWord The command word.
      /// Return the Response for the command.
      public Response getResponse(string cmdWord)
      {
         return responses[cmdWord];
      }
   }
}
