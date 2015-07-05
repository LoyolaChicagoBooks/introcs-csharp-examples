using System;

namespace IntroCS
{
   public class StringArrayDemo
   {
      public static void Main()
      {
         string[] user = StringArray.InputNStrings (4);
         Console.WriteLine ("You entered:");
         StringArray.PrintStrings(user);
         Console.WriteLine ("Now copied to upper case:");
         StringArray.PrintStrings(StringArray.NewUpper(user));
         Console.WriteLine ("Now changing the array from you:");
         StringArray.AllToUpper (user);
         StringArray.PrintStrings(user);
         Console.WriteLine (
            "Now using anonymous array from {\"What\", \"is\", \"this?\"}");
         Console.WriteLine (" copied to upper case:");
         StringArray.PrintStrings(
            StringArray.NewUpper(new[] {"What", "is", "this?"}));
      }
   }
}
