class InterfaceDemo8 : abc, def // comma separated interfaces
{
   public static void Main()
   {
      System.Console.WriteLine("Hello Interfaces");
      InterfaceDemo8 refDemo = new InterfaceDemo8();
      abc refabc = refDemo;
      refabc.xyz();
      def refdef = refDemo;
      refdef.pqr();
//      refdef.xyz();  /* try uncommenting line */
   }

   public void xyz()
   {
      System.Console.WriteLine("In xyz");
   }

   public void pqr()
   {
      System.Console.WriteLine("In pqr");
   }
}

interface abc
{
   void xyz();
}

interface def// extra added interface
{
   void pqr();
}

/*
A class can satisfy more than one interface.
Each must be announced in the class heading.

We can take an object of that class type, refDemo, and use it to
initialize a variable of any interface type satisfied by the class,
as we initialized refabc and refdef.
When a variable is declared as a particular interface type,
any method from that interface can be called using that
variable.

However, if you uncomment the last line of Main,
you get a compiler error:  Though the object
refered to by refdef really is an InterfaceDemo8,
which has the xyz method, the object is declared
as an object of interface def type, which does not
include method xyz.

Code modified from Chetan Kudalkar's article
http://www.codeproject.com/Articles/18743/Interfaces-in-C-For-Beginners
*/