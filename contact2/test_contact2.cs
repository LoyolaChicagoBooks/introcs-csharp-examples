using System;
using System.Collections.Generic;

namespace IntroCS
{
   public class TestContact2
   {                                        // main chunk                                           
      public static void Main()
      {
         Contact c1 = new Contact("Marie Ortiz", "773-508-7890", 
                                  "mortiz2@luc.edu");
         Contact c2 = new Contact("Otto Heinz", "773-508-9999", 
                                  "oheinz@luc.edu");
         Console.WriteLine("Marie's full name: " + c1.GetName());
         Console.WriteLine("Her phone number: " + c1.GetPhone());
         Console.WriteLine("Her email: " + c1.GetEmail());         
         Console.WriteLine("All together:\n{0}", c1); 
         Console.WriteLine("Full contact info for Otto:");
         c2.Print(); 
         c1.SetEmail("maria.ortiz@gmail.com");
         c2.SetPhone("123-456-7890");
         Console.WriteLine("With changes and added contact:");
         var allc = new List<Contact>(new Contact[] {c1, c2, 
            new Contact("Amy Li", "847-111-2222", "amy.li22@yahoo.com")});
         foreach(Contact c in allc) {
            Console.WriteLine("\n"+c);
         }
      }
   }                                       // end of chunk
}