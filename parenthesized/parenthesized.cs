using System;

class Parenthesized
{
   static void Main()
   { 
      string s = "What (really) happened?";
      Console.WriteLine ("Original: " + s);
      Console.WriteLine ("In parentheses: " + InsideParen(s));
   }

   /// Assume s contains parentheses.
   /// Return the substring between the first parentheses.
   static string InsideParen(string s)
   {
      int first = s.IndexOf('(') + 1;  
      int past = s.IndexOf(')');
      int len = past - first;
      return s.Substring(first, len);
   }
}
