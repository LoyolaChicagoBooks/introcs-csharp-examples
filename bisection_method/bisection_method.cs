using System;

namespace IntroCS
{
   interface Function {
      double f(double x);
      string ToString();
   }

   public class Polynomial : Function {
      private double[] coef; // decreasing powers

      public Polynomial(double[] coefficients)
      {
         int len = coefficients.Length, deg = len - 1;
         while (deg > 0 && coefficients[deg] == 0)
            deg--; // leading 0's are redundant
         coef = new double[deg+1];
         for (int i = 0; i <= deg; i++)
            coef[deg - i] = coefficients[len - 1 - i];
      }

      public double f(double x) {
         double sum = 0;
         foreach (double c in coef)
            sum = sum * x + c;
         return sum;
      }

      public override string ToString()
      { 
         string s = "f(x) = ";
         int deg = coef.Length - 1;
         for (int i = 0; i < deg; i++)
            s += string.Format("{0}x^{1} + ", coef[i],  deg - i);
         return s + coef[deg];
      }         
   }

   public class TrigSum : Function {
      public double f(double x) {
         return Math.Sin(x) - Math.Cos(x);
         // This should have solution pi/4 
      }

      public override string ToString()
      { return "f(x) = sin x - cos x"; }         
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
         // a must be less than b so we can do the interval search 
         if( a >= b)
            return double.NaN;
         Console.WriteLine ("a >= b ok");
         bool ok = false;

         // The function must cross the x-axis between the endpoints, 
         //   meaning its sign changes. 
         if (F.f(a) < 0 && F.f( b) > 0) {
            Console.WriteLine ("Test 1 passed");
            ok = true;
         }
         if(F.f(a) > 0 && F.f( b) < 0) {
            Console.WriteLine ("Test 2 passed");
            ok = true;
         }
         if( !ok)
            return double.NaN;
         int n=0;
         while (n < iterations) {
            double c = (a + b) / 2;
            Console.WriteLine ("a = {0}  b={1}", a, b);
            if( F.f(c) == 0 || (b - a)/2 < tolerance)
               return c;
            if( Math.Sign(F.f( c)) == Math.Sign(F.f( a)))
               a = c;
            else
               b = c;
            n = n+1;

         }
         return double.NaN;
      }


      /// This bisection method returns the best double approximation
      /// to a root of F.f.  Returns double.NaN if the F.f(a)*F.f(b) > 0.
      /// Does not require a < b.
      public static double Bisection(Function F, double a, double b) {
         if( F.f(a) == 0) 
            return a;
         if( F.f(b) == 0) 
            return b;
         if( Math.Sign(F.f( b)) == Math.Sign(F.f( a))) //or F.f(a)*F.f(b)>0
            return double.NaN;
         double c = (a + b) / 2;
         // If no f(c) is exactly 0, iterate until the smallest possible 
         // double interval, when there is no distinct double midpoint.
         while (c != a && c != b) { 
            Console.WriteLine ("a = {0}  b= {1} diff = {2}", a, b, b-a);
            if( F.f(c) == 0) {
               return c;
            }
            if( Math.Sign(F.f( c)) == Math.Sign(F.f( a)))
               a = c;
            else
               b = c;
            c = (a + b) / 2;
         }
         return c; // double value matches an endpoint here
      }

      public static void Main (string[] args)
      {
         Function p = new Polynomial(new double[] { 1, 0, -2 });
         // This should have solution x = +/- square root of 2  
         ShowBisection(p, 0, 2, .0001, 100);
         ShowBisection(p, 0, 1, .0001, 100);
         p = new Polynomial(new double[] { 1, -3, -3, 1 });
         // This should have solution x = -1.  -1 - 3 + 3 + 1 = 0  
         ShowBisection(p, -10.0, 10.0, .001, 10000);

         ShowBisection(new TrigSum(), 0, 1, .00001, 100);  // pi / 4  
      }

      /// Shows parameters and both bisection functions.
      static void ShowBisection(Function F, double a, double b, 
                                double tolerance, int iterations)
      {
         Console.WriteLine("\nLet " + F);
         Console.WriteLine("Looking for a root in [{0}, {1}].", a, b);
         Console.WriteLine("First have tolerance {0} and max iterations {1}.",
                           tolerance, iterations);
         double root = Bisection(F, a, b, tolerance, iterations);
         if (!double.IsNaN(root))  // Nan not equal to itself!
            Console.WriteLine ("An approximate root is " + root);
         else
            Console.WriteLine ("Could not find the root");
         Console.WriteLine ("\nNow look for the best double approximation:");
         root = Bisection(F, a, b);
         if (!double.IsNaN(root))
            Console.WriteLine ("The best double approximate root is " + root);
         else
            Console.WriteLine ("Could not find the root");
      }

   }
}
