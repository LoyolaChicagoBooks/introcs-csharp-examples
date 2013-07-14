using System; 

class BadSum 
{
   static void Main()
   {
      string s, t, sum;
      Console.Write ( "Enter an integer: ");
      s = Console.ReadLine();
      Console.Write( "Enter another integer: ");
      t = Console.ReadLine();
      sum = s + t;
      Console.WriteLine("They add up to " + sum);
   }
}
