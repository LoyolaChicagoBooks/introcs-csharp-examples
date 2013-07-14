using System;

namespace IntroCS
{
   interface Function {
      double f(double x);
   }

   public class MyFunction : Function {
      public double f(double x) {
         return x * x * x - 3 * x * x - 3 * x + 1;
         // This should have solution x = -1.  -1 - 3 + 3 + 1 = 0 
      }   
   }

   class BisectionMethod
   {

      /// This is the basic bisection method.
      /// Ported straight from http://en.wikipedia.org/wiki/Bisection_method.
      /// Source: Burden, Richard L.; Faires, J. Douglas (1985), 
      ///   "2.1 The Bisection Algorithm",
      /// Numerical Analysis (3rd ed.), PWS Publishers
      public static double Bisection(Function F, double a, double b, 
                                     double tolerance, int iterations) {
         // check the preconditions for the method to work

         // a must be greater than b so we can do the interval search 
         if (a >= b)
            return double.NaN;
         Console.WriteLine ("a >= b ok");
         bool ok = false;

         // The function must cross the x-axis between the endpoints, 
         //   meaning its sign changes. 
         if ((F.f(a) < 0 && F.f (b) > 0)) {
            Console.WriteLine ("Test 1 passed");
            ok = true;
         }
         if ((F.f(a) > 0 && F.f (b) < 0)) {
            Console.WriteLine ("Test 2 passed");
            ok = true;
         }
         if (!ok)
            return double.NaN;
         int n=0;
         while (n < iterations) {
            double c = (a + b) / 2;
            Console.WriteLine ("a = {0}  b={1}", a, b);
            if (F.f(c) == 0 || (b - a)/2 < tolerance)
               return c;
            if (Math.Sign(F.f (c)) == Math.Sign (F.f (a)))
               a = c;
            else
               b = c;
            n = n+1;

         }
         return double.NaN;
      }


      /// This bisection method returns the best double approximation
      /// to a root of F.f.  Returns double.NaN if the F.f(a)*F.f(b) > 0.
      public static double Bisection(Function F, double a, double b) {
         if (F.f(a) == 0) {
            return a;
         }
         if (F.f(b) == 0) {
            return b;
         }
         if (Math.Sign(F.f (b)) == Math.Sign (F.f (a))) { //or F.f(a)*F.f(b)>0
            return double.NaN;
         }
         double c = (a + b) / 2;
         // If no f(c) is exactly 0, iterate until the smallest possible 
         // double interval, when there is no distinct double midpoint.
         while (c != a && c != b) { 
            Console.WriteLine ("a = {0}  b= {1}", a, b);
            if (F.f(c) == 0) {
               return c;
            }
            if (Math.Sign(F.f (c)) == Math.Sign (F.f (a)))
               a = c;
            else
               b = c;
            c = (a + b) / 2;
         }
         return c;
      }

      public static void Main (string[] args)
      {
         MyFunction MyF = new MyFunction();
         int iterations = 10000;
         double tolerance = 0.001;
         double root = Bisection (MyF, -100.0, 100.0, tolerance, iterations);
         if (root != double.NaN)
            Console.WriteLine (
               "An approximate root of f(x) = x^3 - 3x^2 - 3x + 1 is {0}", 
               root);
         else
            Console.WriteLine ("Could not find the root");
      }
   }
}
