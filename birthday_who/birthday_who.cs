using System;

class Birthday_Who
{
   static void HappyBirthday(string person)
   {
      Console.WriteLine ("Happy Birthday to you!");
      Console.WriteLine ("Happy Birthday to you!");
      Console.WriteLine ("Happy Birthday, dear " + person + ".");
      Console.WriteLine ("Happy Birthday to you!");
   }

   static void Main()
   {
      string userName;
      Console.WriteLine("Who would you like to sing Happy Birthday to?");
      userName = Console.ReadLine();
      HappyBirthday(userName);
   }

}
