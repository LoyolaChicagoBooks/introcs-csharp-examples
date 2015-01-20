using System;
namespace IntroCS
{
   class AveragerDemo 
   {
      public static void Main() 
      {                             // body chunk
         Averager a = new Averager();
         Console.WriteLine("New Averager: " + a);
         foreach (double x in new[] {5.1, -7.3, 11.0, 3.7}) {
            Console.WriteLine ("Next dataum " + x);
            a.AddDatum (x);
            Console.WriteLine("average {0} with {1} data values", 
               a.GetAverage(), a.GetDataCount());
         }
         a.Clear();
         Console.WriteLine("After clearing:");
         Console.WriteLine("average {0} with {1} data values", 
            a.GetAverage(), a.GetDataCount());
      }                            // end chunk
   }
}

