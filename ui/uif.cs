using System;

namespace IntroCS
{
   /// User Input First version (bombs in Parse with mistyping)
   public class UIF  
   {
      /// After displaying the prompt, return a line from the keyboard.
      public static string PromptLine(string prompt)
      {
         Console.Write(prompt);
         return Console.ReadLine();
      }
      
      /// After displaying the prompt, 
      /// return an integer entered from the keyboard.
      public static int PromptInt(string prompt)
      {
         Console.Write(prompt);
         return int.Parse(Console.ReadLine());
      }
      
      /// After displaying the prompt, 
      /// return a double entered from the keyboard.
      public static double PromptDouble(string prompt)
      {
         Console.Write(prompt);
         return double.Parse(Console.ReadLine());
      }
      
      /// After displaying the prompt, 
      /// return  true if 'y' is entered from the keyboard
      /// and false otherwise.
      public static bool Agree(string prompt)
      {
         Console.Write(prompt);
         return "y" == Console.ReadLine();
      } 
   } 
}

