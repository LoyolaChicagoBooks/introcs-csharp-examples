using System;

namespace IntroCS
{
   public class TestContact
   {
      public static void Main()
      {
         Contact c1 = new Contact("Marie Ortiz", "773-508-7890", 
                                  "mortiz2@luc.edu");
         Contact c2 = new Contact("Otto Heinz", "773-508-9999", 
                                  "oheinz@luc.edu");
         Console.WriteLine("Marie's full name: " + c1.GetName());
         Console.WriteLine("Her phone number: " + c1.GetPhone());
         Console.WriteLine("Her email: " + c1.GetEmail());         
         Console.WriteLine("\nFull contact info for Otto:");
         c2.Print(); 
      }
   }
}