using System;
namespace IntroCS
{
   public interface IGame  // Note *interface* in place of *class*
   {
       /// Play the game and return the final score
   	 /// where a higher score should be better, 
   	 /// and a negative score is allowed.
       int Play(); // Note semicolon in place of a body
                   //  You can have multiple method headings declared
   }
}