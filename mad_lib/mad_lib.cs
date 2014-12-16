using System;

class MadLib
{
   static void Main()
   { 
      Console.WriteLine("Help make a Mad Lib!");
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine(); // for {0}            
      Console.Write("Enter a food: "); 
      string food = Console.ReadLine();   // for (1}            
      Console.Write("Enter a city: "); 
      string city = Console.ReadLine();   // for {2}

      string storyFormat = @"
Once upon a time, deep in an ancient jungle,
there lived a {0}.  This {0}
liked to eat {1}, but the jungle had
very little {1} to offer.  One day, an
explorer found the {0} and discovered
it liked {1}.  The explorer took the
{1} back to {2}, where it could
eat as much {1} as it wanted.  However,
the {0} became homesick, so the
explorer brought it back to the jungle,
leaving a large supply of {1}.

The End";                                               

      Console.WriteLine(storyFormat, animal, food, city);
   }
}
