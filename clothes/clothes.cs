using System;
namespace IntroCS
{
   class Clothes
   {
      static void Main()
      {                               // main chunk
         double temperature = UIF.PromptDouble("What is the temperature? ");
         if (temperature > 70) {
            Console.WriteLine("Wear shorts.");
         }
         else {
            Console.WriteLine("Wear long pants.");
         }
         Console.WriteLine("Get some exercise outside.");
      }                               // past main chunk
   }
}
