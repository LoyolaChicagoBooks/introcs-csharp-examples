using System; 

class GoodSum 
{
   static void Main()
   {
      Console.Write ( "Enter an integer: ");
      string xString = Console.ReadLine();
      int x = int.Parse(xString);
      Console.Write( "Enter another integer: ");
      string yString = Console.ReadLine();
      int y = int.Parse(yString);
      int sum = x + y;
      Console.WriteLine("They add up to " + sum);
   }
}
