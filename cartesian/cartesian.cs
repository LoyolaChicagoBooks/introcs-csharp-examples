using System;
namespace IntroCS
{
   class Cartesian  // demonstrate nesting if statements
   {                //   rather than just chaining if else ...
      /// Return one of seven description of a location in the 
      /// cartesian plane: orgin, x or y axis but not at the origin
      /// or quadrant I - IV: counter-clockwise from x>0, y>0
      static  string PartOfPlane(int x, int y)
      {                       
         if (x == 0) {
            if (y == 0) {
               return "origin";
            } 
            else {
               return "y axis";
            }
         } 
         else if (y == 0) {
            return "x axis";
         } 
         else if (y > 0) { // now neither x or y is 0
            if (x > 0) {
               return "quadrant I";
            } 
            else { // x < 0
               return "quadrant II";
            }
         } 
         else {  // y < 0
            if (x < 0) {
               return "quadrant III";
            } 
            else { // x > 0
               return "quadrant IV";
            }
         }
      }

      public static void Main() 
      {
         Console.WriteLine(PartOfPlane(
            UI.PromptInt("Integer X: "),
            UI.PromptInt("Integer Y: ") ));
      }

      static  string PartOfPlane2(int x, int y) // shorter 
      { // skipping else's because of return's - harder to follow?                    
         if (y == 0) {
            if (x == 0) {
               return "origin";
            }
            return "x axis";
         }
         if (x == 0) {
            return "y axis";
         } // now neither x or y is 0
         if (y > 0) {
            if (x > 0) {
               return "quadrant I";
            }
            return "quadrant II";
         }
         if (x < 0) { // and y < 0
            return "quadrant III";
         }
         return "quadrant IV";
      }
   }
}
