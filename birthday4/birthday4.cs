using System;

class Birthday4
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
        HappyBirthday("Emily");
        HappyBirthday("Andre");
    }

}
