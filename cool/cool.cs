using System;

class Cool
{
   static void Main()
   {                               // main chunk
      int temperature = 115;
      while (temperature > 112) { // first while loop code
         Console.WriteLine(temperature);
         temperature = temperature - 1;
      }
      Console.WriteLine("The tea is cool enough.");
   }                               // past main chunk
}
