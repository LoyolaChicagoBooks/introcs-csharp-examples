using System;
namespace IntroCS
{
   class Suitcase
   {
      static void Main()
      {                                        //main chunk      
         double weight = 
                UIF.PromptDouble("How many pounds does your suitcase weigh? ");
         if (weight > 50) {
            Console.WriteLine("There is a $25 charge for luggage that heavy.");
         }
         Console.WriteLine("Thank you for your business.");
      }                                       // past main chunk
   }
}
