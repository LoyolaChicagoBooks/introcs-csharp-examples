using System;

namespace IntroCS
{
   /// Class for testing Rational version with operator symbols and casts
   public class TestOps
   {                          
      public static void Main()
      {
         var a = new Rational (3, 4);
         var b = new Rational (7, -2);
         var p = new Rational (-21, 8);
         Console.WriteLine ("All fractions displayed are Rational internally:");
         Console.WriteLine ("{0} * {1} = {2}", a, b, a * b);
         Console.WriteLine ("-{0} = {1}", b, -b);
         int i = 5;
         Console.WriteLine ("{0} * {1} = {2} : implicit int conversion", 
                              i,    b,    i * b);
         double d = 0.3;         
         Console.WriteLine ("{0} * {1} = {2} : implicit conversion to double", 
                              a,    d,    a * d);
         Console.WriteLine ("{0} * {1} == {2} ? {3}", 
                              a,    b,     p, a*b == p);
         Console.WriteLine ("{0} * {1} != {2} ? {3}", 
                              a,    b,     p, a*b != p);
         var t = new Rational (1, 10);
         Console.WriteLine ("(double)({0}) + (double)({1}) == (double)({2}) ? {3}", 
                          t, 2*t, 3*t, (double)t + (double)(2*t) == (double)(3*t));
         Console.WriteLine ("(decimal)({0}) + (decimal)({1}) == (decimal)({2}) ? {3}", 
                          t, 2*t, 3*t, (decimal)t + (decimal)(2*t) == (decimal)(3*t));

         // After coding Rational binary operators /, +, -, <, >, <=, >=.
         // ADD TESTS FOR THEM
      }
   }
}