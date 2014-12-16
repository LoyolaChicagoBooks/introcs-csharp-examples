using System; 

class Interview 
{
   static void Main()  // basic prompt/read/write example
   {
      Console.Write ( "Enter the interviewee's name: ");
      string name = Console.ReadLine();
      Console.Write( "Enter the appointment time: ");
      string time = Console.ReadLine();
      Console.WriteLine(name + " has an interview at " + time + ".");
   }
}
