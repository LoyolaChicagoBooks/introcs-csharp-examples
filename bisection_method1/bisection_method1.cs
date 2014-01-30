using System;

namespace IntroCS
{
   class BisectionMethod1  // In this version f is a fixed function
   {
      static double f(double x) {  // 
			return x * x - 2;
			// This should have solution the square root of 2.
      }
                                               
      /// This is the basic bisection method.
      /// Simplification of http://en.wikipedia.org/wiki/Bisection_method.
      /// Source: Burden, Richard L.; Faires, J. Douglas (1985), 
      ///   "2.1 The Bisection Algorithm",
      /// Numerical Analysis (3rd ed.), PWS Publishers      chunk
      public static double Bisection(double a, double b, 
                                     double tolerance, int iterations) {
         // check the preconditions for the method to work
         // a must be less than b so we can do the interval search 
         if (a >= b)
            return double.NaN;
         Console.WriteLine ("a >= b ok");
         bool ok = false;

         // The function must cross the x-axis between the endpoints, 
         //   meaning its sign changes. 
         if ((f(a) < 0 && f(b) > 0)) {
            Console.WriteLine ("Test 1 passed");
            ok = true;
         }
         if ((f(a) > 0 && f(b) < 0)) {
            Console.WriteLine ("Test 2 passed");
            ok = true;
         }
         if (!ok)
            return double.NaN;
         int n=0;
         while (n < iterations) {
            double c = (a + b) / 2;
            Console.WriteLine ("a = {0}  b={1}", a, b);
            if (f(c) == 0 || (b - a)/2 < tolerance)
               return c;
            if (Math.Sign(f(c)) == Math.Sign(f(a)))
               a = c;
            else
               b = c;
            n++;
         }
         return double.NaN;
      }
                                           //end chunk
      /// This bisection method returns the best double approximation
      /// to a root of f.  Returns double.NaN if the f(a)*f(b) > 0.
      /// Does not require a < b.
      public static double Bisection(double a, double b) {
         if (f(a) == 0) 
            return a;
         if (f(b) == 0) 
            return b;
         if (Math.Sign(f(b)) == Math.Sign (f(a)))  //or f(a)*f(b)>0
            return double.NaN;
         double c = (a + b) / 2;
         // If no f(c) is exactly 0, iterate until the smallest possible 
         // double interval, when there is no distinct double midpoint.
         while (c != a && c != b) { 
            Console.WriteLine ("a = {0}  b= {1}, diff = {2}", a, b, b-a);
            if (f(c) == 0) 
               return c;
            if (Math.Sign(f(c)) == Math.Sign(f(a)))
               a = c;
            else
               b = c;
            c = (a + b) / 2;
         }
         return c;
      }
                                                // end chunk 2
      public static void Main()
      {
         int iterations = 10000;
         double tolerance = 0.001;
			Console.WriteLine("Let f(x) = x^2 - 2.");
			Console.WriteLine("Looking for a root in [0, 2].");
         Console.WriteLine("First have tolerance {0} and max interations {1}.",
                           tolerance, iterations);
			double root = Bisection(0, 2, tolerance, iterations);
         if (!double.IsNaN(root))  // Nan not equal to itself!
            Console.WriteLine ("An approximate root is " + root);
         else
            Console.WriteLine ("Could not find the root");
			Console.WriteLine ("\nNow look for the best double approximatiuon:");
			root = Bisection(0, 2);
         if (!double.IsNaN(root))  
            Console.WriteLine ("The best double approximate root is " + root);
         else
            Console.WriteLine ("Could not find the root");
      }
   }
}

