using System;
using System.Collections.Generic;
namespace IntroCS
{
   /// Starting point for Interface Lab.
   public class PlayGames
   {
      private static Random rand = new Random();

      public static IGame PopRandom(List<IGame> g)
      {
         int n = g.Count;
         int i = rand.Next(n);
         IGame ret = g[i];
         g[i] = g[n-1];
         g.RemoveAt(n-1);
         return ret;
      }

      public static void Main()
      {
         List<IGame> games = new List<IGame>(); // Note Game as a type
         games.Add(new AdditionGame(rand, 100));
         // write at least 2 more different types of Game classes
         // and add a new one of each type to games:
         // ...
           
           
         int totScore = 0;
         do {
            IGame g = PopRandom(games);
            totScore += g.Play();  // use numerical result from the game
         } while (games.Count > 0 && UI.Agree("Want a game? "));
         Console.WriteLine("Thanks for Playing!");
         Console.WriteLine("Your total score is " + totScore);
      }
   }
}