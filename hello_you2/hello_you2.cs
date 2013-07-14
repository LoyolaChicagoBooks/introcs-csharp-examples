using System;

class HelloYou
{
    static void Main ()
    {   
        Console.WriteLine ("What is your name?");
        string name = Console.ReadLine ();
        Console.WriteLine ("Hello, {0}!", name);
    }

}