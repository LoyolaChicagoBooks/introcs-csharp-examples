using System;

namespace IntroCS
{
   /// Class stub for fractions (rational numbers),
   /// version including casts and a start at operator overloading
   public class Rational
   {                          // INVARIENT:
      private int num, denom; // denom > 0, fraction is reduced to lowest terms

      /// Parse a string of an integer, fraction (with /) or decimal (with .)
      ///  and return the corresponding Rational. 
      public static Rational Parse(string s)
      {
         s = s.Trim();
         string[] parts = {s, "1"};
         if (s.Contains("/")) {
            parts = s.Split('/');
         } else if (s.Contains(".")) {
            parts = s.Split('.');
            string zeros = "";
            foreach( char dig in parts[1]) {
               zeros += "0";
            }
            parts[0] += parts[1];
            parts[1] = "1"+zeros;
         }
         return new Rational(int.Parse(parts[0].Trim()),
            int.Parse(parts[1].Trim()));
      }

      /// Create a fraction given numerator and denominator. 
      public Rational(int numerator, int denominator)
      {
         num = numerator;
         denom = denominator;
         normalize();
      }

      public int GetNumerator()
      {
         return num;
      }

      public int GetDenominator()
      {
         return denom;
      }

      /// Create a fraction for an integer value.
      public Rational(int wholeNumber):
      this(wholeNumber, 1)  // new syntax, before body, refers to
      {                         // other constructor using name "this"
      }

      /// Return a string of the fraction in lowest terms,
      /// omitting the denominator if it is 1.
      public override string ToString()
      {
         if (denom != 1)
            return string.Format("{0}/{1}", num, denom);
         return ""+num;
      }

      // still useful as seen later in Interfaces for IComparable interface:

      /// Return a number that is positive, zero or negative, respectively, if
      ///   the value of this Rational is bigger than f,
      ///   the values of this Rational and f are equal or
      ///   the value of this Rational is smaller than f.
      public int CompareTo(Rational f)
      {
         return num*f.denom - denom*f.num;
      }

      /// Return the positive greatest common divisor of parameters a and b.
      private static int gcd(int a, int b)
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

      /// Force the invarient: in lowest terms with a positive denominator.
      private void normalize()
      {                           
         if (denom == 0) { // We really should force an Exception, but we won't.
            Console.WriteLine("Zero denominator changed to 1!");
            denom = 1;
         }
         int n = gcd(num, denom);
         num /= n;         // lowest
         denom /= n;       //    terms
         if (denom < 0) {  // make denom positive
            denom = -denom;
            num = -num;
         }
      }

                                      // operator chunk
      /// * binary multiplication operator 
      public static Rational operator *(Rational f1, Rational f2)
      {                          
         return new Rational(f1.num*f2.num, f1.denom*f2.denom);
      }

      /// - unary negation operator
      public static Rational operator - (Rational r)
      {
         return new Rational(-r.num, r.denom);
      }

      /// binary == operator
      public static Boolean operator ==(Rational f1, Rational f2)
      {
         return f1.num == f2.num && f1.denom == f2.denom;
      }

      /// binary != operator
      public static Boolean operator !=(Rational f1, Rational f2)
      {
         return f1.num != f2.num || f1.denom != f2.denom;
      } // or extra call, but clearly consistent: return !(f1 == f2)

                                            // implicit cast chunk
      /// Code to cast an int to a Rational implicitly when needed. 
      public static implicit operator Rational(int n)
      {
         return new Rational(n, 1);
      }
                                            // to double chunk
      /// Code to cast to a double implicitly when needed. 
      public static implicit operator double(Rational f)
      {
         return (double)f.num/f.denom;
      }
                                              // explicit cast chunk
      /// Code to cast to a decimal with an explicit cast. 
      public static explicit operator decimal(Rational f)
      {
         return (decimal)f.num/f.denom;
      }
                                                 // end chunk
      /// / binary division operator
      public static Rational operator /(Rational f1, Rational f2)
      {                                    
         return null; // FIX THIS CODE!
      }

      // NOW COMPLETELY CODE BINARY OPERATORS FOR +, -, <, >, <=, >=
      // ...
     
   }
}