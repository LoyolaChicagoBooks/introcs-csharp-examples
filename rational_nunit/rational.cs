using System;

namespace IntroCS
{
   /// Class for fractions (rational numbers),
   /// including basic arithmetic operations.
   public class Rational
   {                          // INVARIENT: (true at end of any public method)
      private int num, denom; // denom > 0, fraction reduced to lowest terms
                                    // Parse chunk
      /// Parse a string of an integer, fraction (with /) or decimal (with .)
      ///  and return the corresponding Rational. 
      public static Rational Parse(string s)
      {
         s = s.Trim();      // will adjust numerator and denominator parts
         string[] parts = {s, "1"}; // for an int string, this is correct
         if (s.Contains("/")) {     // otherwise correct num, denom parts
            parts = s.Split('/');
         } else if (s.Contains(".")) {
            string[] intFrac = s.Split('.'); // integer, fractional digits
            parts[0] = intFrac[0]+intFrac[1];  // "shift" decimal point
            parts[1] = "1";                 // denom will have as many 0's 
            foreach( char dig in intFrac[1]) {  //    as digits after '.'
               parts[1] += "0";                 //    to compensate 
            }
         } 
         return new Rational(int.Parse(parts[0].Trim()),
                             int.Parse(parts[1].Trim()));
      }
                                    // constructor chunk
      /// Create a fraction given numerator and denominator. 
      public Rational(int numerator, int denominator)
      {
         num = numerator;
         denom = denominator;
         Normalize();
      }
                                    // getter chunk
      public int GetNumerator()
      {
         return num;
      }

      public int GetDenominator()
      {
         return denom;
      }
                                     // ToString chunk
      /// Return a string of the fraction in lowest terms,
      /// omitting the denominator if it is 1.
      public override string ToString()
      {
         if (denom != 1)
            return string.Format("{0}/{1}", num, denom);
         return ""+num;
      }
                                   // ToDouble chunk
      /// Return a double approximation to the fraction. 
      public double ToDouble()
      {
         return ((double)num)/denom;
      }
                                   
      /// Return a decimal approximation to the fraction. 
      public decimal ToDecimal()
      {
         return ((decimal)num)/denom;
      }
                                         // Reciprocal chunk
      /// Return a new Rational which is the reciprocal of this Rational.
      public Rational Reciprocal()
      {
         return new Rational(denom, num);
      }

      /// Return a new Rational which is this Rational negated.
      public Rational Negate()
      {
         return new Rational(-num, denom);
      }

                                        // Multiply chunk
      /// Return a new Rational which is the product of this Rational and f. 
      public Rational Multiply(Rational f)
      {                           // end Multiply heading chunk
         return new Rational(num*f.num, denom*f.denom);
      }
                                   // Divide chunk
      /// Return a new Rational which is the quotient of this Rational and f. 
      public Rational Divide(Rational f)
      {
         return new Rational(num*f.denom, denom*f.num);
      }
                                   // Add chunk
      /// Return a new Rational which is the sum of this Rational and f. 
      public Rational Add(Rational f)
      {
         return new Rational(num*f.denom + denom*f.num, denom*f.denom);
      }
   
      /// Return a new Rational which is the difference of this Rational and f.
      public Rational Subtract(Rational f)
      {
         return new Rational(num*f.denom - denom*f.num, denom*f.denom);
      }
   
      /// Return a number that is positive, zero or negative, respectively, if
      ///   the value of this Rational is bigger than f,
      ///   the values of this Rational and f are equal or
      ///   the value of this Rational is smaller than f.
      public int CompareTo(Rational f)
      {
         return num*f.denom - denom*f.num; //numerator of this - f
      }
   
      /// Return the positive greatest common divisor of parameters a and b.
      private static int GCD(int a, int b)
      {  // assume a or b is not 0
         if (a == 0)
            return Math.Abs(b);
         while (b != 0) {  // Euclid's algorithm
            int remainder = a % b;
            a = b;
            b = remainder;
         }
         return Math.Abs(a);
      }
                                  // start normalize chunk
      /// Force the invarient: in lowest terms with a positive denominator.
      private void Normalize()
      {                           
         if (denom == 0) { // We *should* force an Exception, but we won't.
            Console.WriteLine("Zero denominator changed to 1!");
            denom = 1;
         }
         int n = GCD(num, denom);
         num /= n;         // lowest
         denom /= n;       //    terms
         if (denom < 0) {  // make denom positive
            denom = -denom;//   double negation:
            num = -num;    //   same mathematical value
         }
      }
   }                                 //end chunk
}
