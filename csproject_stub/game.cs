using System;
using System.Collections.Generic;
namespace IntroCS
{
   
   /// This class is the main class of "Loyola World",
   /// the shell of a text aventure game.
   /// This main class creates and initialises all places and Action objects, 
   /// and runs the main command processing loop.
   /// All commands are executed by objects satifying the Response interface.
   /// This shell is inspired by the Game of Zuul
   /// by authors  Michael Kolling and David J. Barnes. 
   public class Game 
   {
      public Place CurrentPlace {get; set;} // controls public access
      private Dictionary<string, Place> places; //places can be found by name
      private CommandMapper commandMapper;
       
      public static void Main(string[] args)
      {
         Game game = new Game();
         game.play();
      }
       
      /// Return the Place associated with name. 
      public Place getNamedPlace(string name) {
         return places[name];
      }
       
      /// Create the game and initialise its internal map.
      public Game()
      {
         places = Place.createPlaces("place_data.txt");
         CurrentPlace = places["outside"];
         commandMapper = new CommandMapper(this);
      }
   
      ///  Main play routine.  Loops until end of play.
      public void play()
      {
         printWelcome();
         // Enter the main command loop.  Here we repeatedly read commands and
         // Execute them until the game is over.
         while (! processCommand(Command.getCommand()))
            ;  // convention with isolated semiclon for an empty loop
         Console.WriteLine("Thank you for playing.  Good bye.");
      }
   
      /// Print out the opening message for the player.
      private void printWelcome()
      {
         Console.WriteLine(
@"Welcome to Loyola!
This is a pretty boring game, unless you modify it.
Type 'help' if you need help.

{0}", CurrentPlace.getLongDescription());
      }
   
      /// Given a command: process (that is: Execute) the command.
      /// Return true If the command ends the game, false otherwise.
      private bool processCommand(Command command)
      {
         if(!commandMapper.isCommand(command.CommandWord)) {
            Console.WriteLine("I don't know what you mean...");
            return false;
         }
         Response response = commandMapper.getResponse(command.CommandWord);
         return response.Execute(command);
      }
   }
}
