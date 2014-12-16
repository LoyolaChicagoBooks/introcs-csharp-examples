using System; 

class Interview2 
{
   static string InterviewSentence(string name, string time)
   { 
      return string.Format("{0} has an interview at {1}.", name, time);
   }

   static void Main()  // i/o in Main
   {
      Console.Write("Enter the interviewee's name: ");
      string name = Console.ReadLine();
      Console.Write("Enter the appointment time: ");
      string time = Console.ReadLine();
      Console.WriteLine(InterviewSentence(name, time));
   }
}
