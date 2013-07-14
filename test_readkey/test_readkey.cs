using System;

class TestReadKey
{
    static void Main()
    {
      Console.WriteLine("Direct keyboard response, one key at a time, no echo:");
      Console.WriteLine("Type; press q to quit");
      char ch;
      do {
         ConsoleKeyInfo ki = Console.ReadKey(true); // does not echo
         ch = ki.KeyChar;
         Console.WriteLine("You pressed:<{0}> code {1}", ch, (int)ch);
      } while (ch != 'q');
   }
}


