using System;
using System.IO;

namespace IntroCS
{
   class PathExample
   {
      public static void Main(string[] args)
      {
         // This line gets the current working directory (where MonoDevelop is running your code)
         string currentWorkingDirectory = Directory.GetCurrentDirectory();

         // This is the name of the executable (we won't be running it)
         string executable = "path.exe";

         // This tells us the full path that MonoDevelop uses to run your executable.
         string fullpath = Path.Combine(currentWorkingDirectory, executable);
         Console.WriteLine(fullpath);
      }
   }
}
