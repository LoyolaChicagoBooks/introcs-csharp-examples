using System;

class LifetimeVsScope  // distinguish lifetime from scope
{  // Silly example with variables both alive not in scope

   private int instanceVar;

   public LifetimeVsScope(int v)
   {
      instanceVar = v;
   }

   public static void Main()
   {
      int x = 3;
      LifetimeVsScope obj = new LifetimeVsScope(5);
      ScopeHider();
      Console.WriteLine("Still alive! {0} {1}", x, obj.instanceVar);
   }

   static void ScopeHider()  
   {  
      Console.WriteLine("Neither x nor obj is in scope here."); 
   }
}
