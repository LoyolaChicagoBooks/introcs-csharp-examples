using System;
namespace IntroCS
{
   
   /// Response to try to go to a new place.
   public class Goer
   {
      private Game game;
      
      /// Try to go to one direction. If there is an exit, enter the new
      /// place, otherwise print an error message.
      /// Return false(does not end game)
      public bool Execute(Command command)
      {
         if(!command.hasSecondWord()) {
            // if there is no second word, we don't know where to go...
            Console.WriteLine("Go where?");
            return false;
         }
         string direction = command.GetSecondWord();
         // Try to leave current place.
         Place nextPlace = game.GetCurrentPlace().getExit(direction);
         if (nextPlace == null) {
            Console.WriteLine("There is no door!");
         }
         else {
            game.SetCurrentPlace(nextPlace);
            Console.WriteLine(nextPlace.getLongDescription());
         }
         return false;
      }
   
      public string Help()
      {
         return @"Enter
    go direction
to exit the current place in the specified direction.
The direction should be in the list of exits for the current place.";
      }
   
      /// Constructor for objects of class Goer
      public Goer(Game game)
      {
         this.game = game;
      }
   }
}
