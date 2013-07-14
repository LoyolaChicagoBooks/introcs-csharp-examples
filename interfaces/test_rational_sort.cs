using System;
using System.Collections.Generic;

namespace IntroCS
{
   /// Use IComparable<Rational> interface to sort Rationals. 
   class TestRationalSort
   {
      public static void Main(string[] args)
      {
         List<Rational> nums = new List<Rational>();
         nums.Add(new Rational(1, 2));
         nums.Add(new Rational(11, 3));
         nums.Add(new Rational(-1, 10));
         nums.Add(new Rational(2, 5));
         nums.Add(new Rational(2, 3));
         nums.Add(new Rational(1, 3));
         Console.WriteLine("Before sorting: " + ListString(nums));
         nums.Sort();
         Console.WriteLine("After sorting:  " + ListString(nums));
      }

      public static string ListString(List<Rational> list)
      {
         string s = "";
         foreach (Rational r in list) {
            s += r + " ";
         }
         return s;
      }
   }
}
