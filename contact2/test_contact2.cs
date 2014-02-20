using System;

namespace IntroCS
{
   public class TestContact2
   {
      public static void Main()
      {
         Contact c1 = new Contact("Marie Ortiz", "773-508-7890", "mortiz2@luc.edu");
         Contact c2 = new Contact("Otto Heinz", "773-508-9999", "oheinz@luc.edu");
         Console.WriteLine("Marie's full name: " + c1.GetName());
         Console.WriteLine("Her phone number: " + c1.GetPhone());
         Console.WriteLine("Her email: " + c1.GetEmail());         
         Console.WriteLine("Full contact info for Otto:");
         c2.Print(); 
         c1.SetEmail ("maria.ortiz@gmail.com");
         c2.SetPhone ("123-456-7890");
         Console.WriteLine ("Now both with changes:\n" + c1); //no ToString!
         Console.WriteLine ("No ToString needed with + or WriteLine:\n{0}", c2);
      }
   }
}