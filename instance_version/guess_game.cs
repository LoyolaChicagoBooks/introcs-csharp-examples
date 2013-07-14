using System;

namespace IntroCS
{                           
   public class GuessGame  //OOP version of Game from static_version
   {
      private static Random r = new Random();
      private int big;  // moved to instance variable

      public static void Main()
      {
         int bound = UI.PromptInt("Enter a secret number bound: ");
         GuessGame game = new GuessGame(bound);  // need Game object
         game.Play();   // call no-parameter instance method on game
      }

      public GuessGame(int big)
      {
         this.big = big; // need this. to access same-named instance variable
      }
      
      public void Play()  // Not static!  No explicit parameter
      {
         int secret = r.Next(big);    // use instance variable
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
}                         
