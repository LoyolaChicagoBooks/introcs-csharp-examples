using System;
namespace IntroCS
{
   class InputInRange  //version with range added to prompt
   {
      
      public static void Main() //testing routine
      {
         Console.WriteLine(Agree("Do you understand? "));
      }
      
      /// Prompt the user with a question; Return true of false.
      /// Allow certain starting characters for true and
      /// others for false, and repeat until the response
      /// is in one of these groups.
      static Boolean Agree(string question)
      {
         return true;  // so stub compiles
      }
   }                                          
}

