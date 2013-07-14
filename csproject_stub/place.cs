using System;
using System.IO;
using System.Collections.Generic;

namespace IntroCS
{
   
   /// A "Place" represents one location in the scenery of the game.  It is 
   /// connected to other places via exits.  For each existing exit, the place 
   /// stores a reference to the neighboring place.
   /// Derived from work of  Michael Kolling and David J. Barnes
   public class Place
   {
      public string Description { get; private set; }

      private Dictionary<string, Place> exits; // stores exits of this place.
   
      /// Create a place described by description. Initially, it has
      /// no exits.  The description is something like "in a kitchen" or
      /// "in an open court yard".
      public Place (string description)
      {
         Description = description;
         exits = new Dictionary<string, Place> ();
      }
       
      /// Create places and their interconnections by taking place names, exit 
      /// data and descriptions from a text file.  
      /// Return a map of place names to places.  File format for each place: 
      ///   First line:  place name (one word)
      ///   Second line: pairs of exit direction and neighbor place name 
      ///   Remaining paragraph: place description, blank line terminated  
      public static Dictionary<string, Place> createPlaces (string fileName)
      {
         StreamReader reader = FIO.OpenReader(fileName);
         // Map to return
         Dictionary<string, Place> places = new Dictionary<string, Place> ();
          
         // temporary Map to delay recording exits until all places exist
         Dictionary<string, string> exitStrings =
                                       new Dictionary<string, string> ();
          
         while (!reader.EndOfStream) {
            string name = reader.ReadLine ();
            string exitPairs = reader.ReadLine ();
            // You could also substitute your lab's ReadParagraph for the two
            //   lines below if you want to format each paragraph line yourself.
            string description = TextUtil.LineWrap(reader);
            reader.ReadLine(); // assume empty line after description
            places [name] = new Place (description);
            exitStrings [name] = exitPairs;
         }
         reader.Close ();
         // need places before you can map exits
         // go back and use exitPairs to map exits:
         foreach (string name in places.Keys) {
            Place place = places [name];
            string[] parts = TextUtil.SplitWhite(exitStrings[name]);
            for (int i = 0; i < parts.Length; i += 2) {
               place.setExit (parts [i], places [parts [i + 1]]);
            }
         }
         return places;
      }
   
      // Define an exit from this place.
      //  Going to the exit in this direction 
      //  leads to neighbor place.
      public void setExit (string direction, Place neighbor)
      {
         exits [direction] = neighbor;
      }
      
      /// Return a description of the place in the form:
      ///     You are in the kitchen.
      ///     Exits: north west
      public string getLongDescription ()
      {
         return "You are " + Description + ".\n" + getExitstring ();
      }
   
      /// Return a string describing the place's exits, for example
      /// "Exits: north west".
      private string getExitstring ()
      {
         string s = "Exits: ";
         foreach (string e in exits.Keys) {
            s += e + ' ';
         }
         return s;
      }
   
      /// Return the place that is reached if we go from this place in direction
      /// "direction". If there is no place in that direction, return null.
      public Place getExit (string direction)
      {
         if (exits.ContainsKey (direction)) {
            return exits [direction];
         }
         return null; 
      }
   }
}
