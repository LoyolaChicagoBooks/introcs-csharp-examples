using System; 

class GlazerCalc  // Miles' first C# Yellow Book example
{
   static void Main()
   {
      double width, height, woodLength, glassArea;
      string widthString, heightString;
      Console.Write ( "Enter window width: ");
      widthString = Console.ReadLine();
      width = double.Parse(widthString);
      Console.Write ( "Enter window height: ");
      heightString = Console.ReadLine();
      height = double.Parse(heightString);
      
      woodLength = 2 * ( width + height ) * 3.25 ;
      glassArea = 2 * ( width * height ) ;
      
      Console.WriteLine ( "The length of the wood is " +
                          woodLength + " feet" ) ;
      Console.WriteLine( "The area of the glass is " +
                         glassArea + " square metres" ) ;
   }
}
