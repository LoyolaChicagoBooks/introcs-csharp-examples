using System;

namespace IntroCS
{
   class LoopLab  
   {
   
      static void Main() //testing routine
      {
         int n = UI.PromptIntInRange("Enter a number of repetitions: ", 0, 30);
         string s = UI.PromptLine("Enter a string: ");
         Console.Write("Direct print {0} reps of {1}: ", n, s);
         PrintReps(s, n);
         Console.WriteLine("\n\nPrint returned string of repeats: {0}",
                           StringOfReps(s, n));
         Console.WriteLine("{0}! is {1}.", n, Factorial(n));        
         PrintRectangle(3, 2, 'i', 'e');
         PrintRectangle(5, 1, ' ', 'B');
         PrintRectangle(0, 2, '-', '+');
         PrintTableBorders(3, 2, 4, 1);
         PrintTableBorders(2, 1, 6, 3);
      } 
                                                             // PrintReps chunk
      /// Print n copies of s, end to end.
      /// For example PrintReps("Ok", 9) prints: OkOkOkOkOkOkOkOkOk
      static void PrintReps(string s, int n)
      {                                                      //body
         Console.Write("Not Implemented");
      }
                                                           //StringOfReps chunk    
      /// Return a string containing n copies of s, end to end.
      /// For example StringOfReps("Ok", 9) returns: "OkOkOkOkOkOkOkOkOk"
      static string StringOfReps(string s, int n)
      {                                                     // body
         return "Not implemented";
      }
                                                            // Factorial chunk
      /// Return n! (n factorial: 1*2*3 *...* n if n >=1; 
      /// 0! is 1.).  For example Factorial(4) returns 1*2*3*4 = 24.
      static int Factorial(int n)
      {                                                     // body
         return 1;  // so it compiles
      }
                                                         //PrintRectangle chunk
      // Print a filled rectange, where the filling is 
      // the specified number of columns and rows of the character inChar,
      // surrounded by a border made of the character edgeChar.
      // For example printRectangle(3, 2, 'i', 'e') prints
      //    eeeee
      //    eiiie
      //    eiiie
      //    eeeee
      static void PrintRectangle(int columns, int rows, 
                                 char inChar, char edgeChar)
      {                                                     // body
         Console.WriteLine("Not implemented");
      }
                                                     //PrintTableBorders chunk
      /// Print the borders of the cells of a table. 
      /// The borders divide the table into rows and columns.
      /// The blank space within a cell is width characters wide
      /// and continues down for height lines.
      /// The horizontal borders are dashes '-' and the vertical borders
      /// are vertical bars, '|', except that all intersections are '+'.
      /// For example PrintTableBorders(3, 2, 4, 1) prints
      ///    +----+----+----+
      ///    |    |    |    |
      ///    +----+----+----+
      ///    |    |    |    |
      ///    +----+----+----+
      static void PrintTableBorders(int columns, int rows, 
                                    int width, int height)
      {                                                     // body
         Console.WriteLine("Extra Credit Not implemented");
      }

   }
}

