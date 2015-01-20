using System;
namespace IntroCS
{
   class ClockDemo 
   {
       public static void Main() 
      {                             // body chunk
         Clock c = new Clock();
         Console.WriteLine("Midnight " + c.GetTimeString());
         c.SetTime(23, 58);
         Console.WriteLine("Before midnight " + c.GetTimeString());
         for (int i = 0; i < 4; i++) {
            c.Tick ();
            Console.WriteLine ("Tick " + c.GetTimeString());
         }
      }                            // end chunk
   }
}
   