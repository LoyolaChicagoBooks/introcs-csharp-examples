using System;
namespace IntroCS
{
   class Wages  //with alternate version of CalcWeeklyWages
   {
      /// Return the total weekly wages for a worker working 
      /// totalHours with a given regular hourlyWage.  
      /// Include overtime for hours over 40.
      static double CalcWeeklyWages(double totalHours, double hourlyWage)
      {                       
         double regularHours, overtime;
         if (totalHours <= 40) {
            regularHours = totalHours;
            overtime = 0;
         }
         else {
            regularHours = 40;
            overtime = totalHours - 40;
         }
         return hourlyWage*regularHours + (1.5*hourlyWage)*overtime;
      }                      
      //end CalcWeeklyWages chunk
      static void Main()  // rest same as in Wages1.cs
      {
         double hours = UIF.PromptDouble("Enter hours worked: ");
         double wage = UIF.PromptDouble("Enter dollars paid per hour: ");
         double total = CalcWeeklyWages(hours, wage);
         Console.WriteLine(
            "Wages for {0} hours at ${1:F2} per hour are ${2:F2}.",
            hours, wage, total);
      }
   }
}
