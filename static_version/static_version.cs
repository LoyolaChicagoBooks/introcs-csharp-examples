using System;

namespace IntroCS
{                           // start GuessGame chunk
   public class Game
   {
      private static Random r = new Random();

      public static void Main()
      {
         int big = UI.PromptInt("Enter a secret number bound: ");
         Play(big);
      }

      public static void Play(int big)
      {
         int secret = r.Next(big);
         int guesses = 1;
         Console.WriteLine("Guess a number less than {0}.", big);
         int guess = UI.PromptInt("Next guess: ");
         while (secret != guess) {
            if (guess < secret) {
               Console.WriteLine("Too small!");
            } else {
               Console.WriteLine("Too big!");

            }
            guess = UI.PromptInt("Next guess: ");
            guesses++;
         }
         Console.WriteLine("You won on guess {0}!", guesses);
      }
   }
}                           // end GuessGame chunk
