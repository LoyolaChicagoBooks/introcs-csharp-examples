using System;

class Return2
{
   static string LastFirst(string firstName, string lastName)
   {
      string separator = ", ";
      string result = lastName + separator + firstName;
      return result;
   }

    static void Main()
    {
        Console.WriteLine(LastFirst("Benjamin", "Franklin"));
        Console.WriteLine(LastFirst("Andrew", "Harrington"));
    }
}
