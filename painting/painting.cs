using System; 

class Painting 
{
   static void Main()
   {
      double width, length, wallArea, ceilingArea;
      string widthString, lengthString;
      double HEIGHT = 8;
      
      Console.WriteLine ( "Calculation of Room Paint Requirements");
      Console.Write ( "Enter room length: ");
      lengthString = Console.ReadLine();
      length = double.Parse(lengthString);
      Console.Write( "Enter room width: ");
      widthString = Console.ReadLine();
      width = double.Parse(widthString);
      
      wallArea = 2 * (length + width) * HEIGHT; // ignore doors
      ceilingArea = length * width;
      
      Console.WriteLine("The wall area is " + wallArea 
                          + " square feet.");
      Console.WriteLine("The ceiling area is " + ceilingArea 
                          + " square feet.");
   }
}
