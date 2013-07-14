using System;

/// A simple class / object example:
class Example // nothing in here is marked static
{
   private int n; // one instance variable or "attribute"
   private double d; // another - these form an Example object's state
                                               // constructor chunk
   public Example(int n, double d) // a constructor - no return type
   {
      this.n = n; this.d = d; // "this" is required (why?)
   }
                                             // end constructor chunk
   public int GetN() // a "getter" method
   {
      return n;
   }

   public double GetD() // another
   {
      return d;
   }
                                           // SetN chunk
   public void SetN(int n) // a "setter" method
   {
      this.n = n;
   }
                                        // end SetN chunk
   public void SetD(double d) // another
   {
      this.d = d;
   }
   
   public override string ToString() // 'override' is required
   {
      return "Example: n = " + n + ", d = " + d;
   }
} // end of class Example


/// A simple test class for Example:
class ExampleTest
{
   public static void Main()
   {
      Example e = new Example(1, 2.5); // use constructor
      // this creates the first Example object with reference e
      Console.WriteLine("e.n = {0}", e.GetN()); // prints 1
      Console.WriteLine("e.d = {0}", e.GetD()); // prints 2.5
      Console.WriteLine(e); // prints Example: n = 1, d = 2.5
      
      e.SetN(25);
      e.SetD(3.14159);
      Console.WriteLine("e.n = {0}", e.GetN()); // prints 25
      Console.WriteLine("e.d = {0}", e.GetD()); // prints 3.14159
      Console.WriteLine(e); // prints Example: n = 25, d = 3.14159
      
      Example e2 = new Example(3, 10.5); 
      // this creates the second Example object with reference e2
      Console.WriteLine(e2); // prints Example: n = 3, d = 10.5
      
      e = e2; // now both e and e2 reference the second object
      // the first Example object is now no longer referenced
      // and its memory can be reclaimed at runtime if necessary
      Console.WriteLine(e); // prints Example: n = 3, d = 10.5

      e2.SetN(77);  // symbolism uses e2, not e
      Console.WriteLine(e2); // prints Example: n = 77, d = 10.5 
      Console.WriteLine(e); // prints Example: n = 77, d = 10.5 
      // but e is the same object - so its fields are changed 
   }
} // end of class ExampleTest
