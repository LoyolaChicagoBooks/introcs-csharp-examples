using System;
using System.Collections.Generic;  //added

/// elaboration allowing sorting via IComparable interface:
class Example : IComparable<Example> //new: interface mention
{
   private int n; 
   private double d; 

   public Example(int n, double d) 
   {
      this.n = n; this.d = d; 
   }

   public int GetN() 
   {
      return n;
   }

   public double GetD() 
   {
      return d;
   }
  
   public void SetN(int n) 
   {
      this.n = n;
   }

   public void SetD(double d) 
   {
      this.d = d;
   }

   public override string ToString() 
   {
      return "Example: n = " + n + ", d = " + d;
   }

   // new method required for the interface
   public int CompareTo(Example other)
   {
      if (n != other.n) {
         return n - other.n;
      }
      if (d > other.d) {
         return 1;
      }
      if (d < other.d) {
         return -1;
      }
      return 0;
   }
} // end of class Example


class ExampleSortingDemo
{
   public static void Main()
   {
      var pairs = new List<Example> (new[] { new Example(5, 1.1), 
         new Example(2, 9.9), new Example(5, -.3), 
         new Example(22, 0), new Example(5, 1.1)});
      foreach (Example e in pairs) {
         Console.WriteLine(e);
      }
      Console.WriteLine("Sorted:");
      pairs.Sort();
      foreach(Example e in pairs) {
         Console.WriteLine(e);
      }
   }
} // end of class ExampleTest
