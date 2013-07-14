using System;
namespace IntroCS
{
   
   class AdditionGame : IGame  // note :IGame  !!
   {
       private Random rand;
       private int n;
   
       // Constructor for objects of class AdditionGame
       public AdditionGame(Random r, int big)
       {
           rand = r;
           n = big;
       }
       
       // Play all games and keep score.
       public int Play()  // exactly matches heading in Game interface
       {
           int score = 0;
           for (int i = 0; i < 3; i++) {
               int x = rand.Next(n), y = rand.Next(n), ans = x+y;
               string prompt = string.Format("Enter the sum: {0} + {1} = ", x, y);
               int val = UI.PromptInt(prompt);
               if (ans == val) {
                   Console.WriteLine("Correct!");
                   score++;
               }
               else
                   Console.WriteLine("Wrong!  Right answer is " + ans);
           }        
           return score;    
       }
   }
}
