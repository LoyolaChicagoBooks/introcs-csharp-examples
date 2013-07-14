using System;

namespace IntroCS
{
   class Grade
   {                        // function chunk
      /// Return letter grade for score. 
      static char letterGrade(double score)
      {
         char letter;
         if (score >= 90) {
            letter = 'A';
         }
         else if (score >= 80) { // grade must be B, C, D or F
           letter = 'B';
         }
         else if (score >= 70) { // grade must be C, D or F
            letter = 'C';
         }
         else if (score >= 60) { // grade must D or F
            letter = 'D';
         }
         else {
            letter = 'F';
         }
         return letter;
      }
                           // end of function chunk
      static void Main()
      {
         double g = UIF.PromptDouble("Enter a numerical grade: ");
         Console.WriteLine("Your letter grade is {0}.", letterGrade(g));
      }
   }
}
