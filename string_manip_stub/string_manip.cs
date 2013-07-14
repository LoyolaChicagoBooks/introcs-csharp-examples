using System;

// problem stub for class -- significant logical sequence 
class StringManip
{                                              // main chunk
    static void Main ()
    {
        string str1 = "It was the best of times.";
        string str2 = "Of times it was the best.";
        Console.WriteLine("str1=" + str1);
        Console.WriteLine("str2=" + str2);
        Console.WriteLine();
        // to embed a quote inside a string constant, precede it by backslash(\).
        Console.WriteLine("Let us do some \"cutting and pasting\" of strings!");
        string str3 = replaceFirst(str1, "best", "worst");
        Console.WriteLine("str3 = str1 with best => worst: " + str3);
        string str4 = replaceFirst(str2, "best", "worst");
        Console.WriteLine("str2 with best => worst: " + str4);
        string str5 = replaceFirst(str3, "worst", "best");
        Console.WriteLine("str3 with worst => best: " + str5);
    }
                                              // end main chunk  
    /// Return s with the first occurence of target
    /// replaced by replacement.
    static string replaceFirst(string s, string target,
                               string replacement)
    {
        return "Not implemented"; // so it compiles
    }
    
    /// Most concrete version:
    /// Assume s is "It was the best of times"
    /// target is "best"
    /// replacement is "worst"
    static string replaceFirst1(string s, string target,
                                string replacement)
    {   
        // here totally concrete, but you still must 
        // understand what is being asked:
        // want string "It was the worst of times." and
        // it is returned!
        return "It was the worst of times";
    }
    
    // Rather than jump to the most general s, which varies in
    // content, length, and placement of the target,
    // assume the target is best, and in the same place, but you do not
    // know what the other characters are ahead of time:
    // s is "???????????best??????????"
    //       0123456789012345678901234
    static string replaceFirst2(string s, string target,
                                string replacement)
    {   /* plan:
        
        */
        return "Not implemented"; // so it compiles
    }
    
    /*
    In another version you might assume the target was best, 
    it could be at a different place in the string.
    Finally you would make the generalization the that the target
    could be anything, with any length, and get the next version.
    */

    /// Return s with the first occurence of target
    ///  replaced by replacement.  As far as we got,
    ///  the target is ASSUMED to be in s.
    static string replaceFirst3(string s, string target,
                                string replacement)
    {   // code in class! ASSUME target appears in s
        return "Not implemented"; // so it compiles
    }
    
    // The truly final version would probably allow for the target
    // to not be in s:

}
