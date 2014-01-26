using System;
namespace IntroCS
{
   class TestAgree  
   {
      
      public static void Main() //testing routine
      {
         Console.WriteLine(Agree("Do you understand? "));
      }
      
      /// Prompt the user with a question; Return true of false.
      /// Allow certain starting characters for true (t, y) and
      /// others for false (f, n), and repeat until the response
      /// is in one of these groups.
      static Boolean Agree(string question)
      {
         return true;  // so stub compiles
      }
   }                                          
}

