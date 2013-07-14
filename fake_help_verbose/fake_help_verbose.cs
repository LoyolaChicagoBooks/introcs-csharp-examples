using System;
using System.IO;
using System.Collections.Generic;

namespace IntroCS
{
   class FakeHelpVerbose
   {
      static Random rand = new Random();

      public static void Main(string[] args)
      {
         List<string> guessList = GetParagraphs();
         Dictionary<string, string> responses = GetDictionary();

         string prompt = "\n> ";
         Console.WriteLine(@"Welcome to We-Give-Answers!
What do you have to say?");
         Console.Write("\nEnter 'bye' to end our session.");
         string fromUser;
         do {
            fromUser = UI.PromptLine(prompt).ToLower().Trim();
            if (fromUser != "bye") {
               string answer = Response(fromUser, guessList, responses);
               Console.WriteLine('\n' + answer);
            }
         } while (fromUser != "bye");
         Console.WriteLine(@"
We-Give-Answers
thanks you for your patronage.
Call again if we can help you
with any other problem!");
      }

      public static string Response(string fromUser, List<string> guessList,
                                    Dictionary<string, string> responses)
      {
         char[] sep = "\t !@#$%^&*()_+{}|[]\\:\";<>?,./".ToCharArray();
         string[] words = fromUser.ToLower().Split(sep);
         foreach (string word in words) {
            if (responses.ContainsKey(word)){
               return responses[word];
            }
         }
         return guessList[rand.Next(guessList.Count)];

      }

      /// Establish random responses by repetitive data recording
      public static List<string> GetParagraphs()
      {
         List<string> all = new List<string>();
         all.Add(@"No other customer has ever complained
about this before.  What is your system
configuration?");
         all.Add(@"That sounds odd. Could you describe
that problem in more detail?");
         all.Add("That sounds interesting. Tell me more...");
         all.Add("I need a bit more information on that.");
         all.Add(@"Have you checked that you do not have a
dll conflict?");
         all.Add(@"That is explained in the manual.
Have you read the manual?");
         all.Add(@"Your description is a bit wishy-washy.
Have you got an expert there with you
who could describe this more
precisely?");
         all.Add("That's not a bug, it's a feature!");
         all.Add("Could you elaborate on that?");
         return all;
      }

      /// Establish response dictionary by repetitive data recording
      public static Dictionary<string, string> GetDictionary()
      {
         Dictionary<string, string> d = new Dictionary<string, string>();
         d["crash"] = @"Well, it never crashes on our system.
It must have something to do with your system.
Tell me more about your configuration.";
         d["slow"] = @"I think this has to do with your hardware.
Upgrading your processor should solve all
performance problems.
Have you got a problem with our software?";
         d["performance"] = @"Performance was quite adequate in all our tests.
Are you running any other processes in the background?";
         d["bug"] = @"Well, you know, all software has some bugs. 
But our software engineers are working very hard to fix them. 
Can you describe the problem a bit further?";
         d["windows"] = @"This is a known bug to do with the Windows 
operating system.  Please report it to Microsoft. 
There is nothing we can do about this.";
         d["macintosh "] = @"This is a known bug to do with the Mac 
operating system.  Please report it to Apple.
There is nothing we can do about this.";
         d["expensive"] = @"The cost of our product is quite competitive. 
Have you looked around and really compared our features?";
         d["installation"] =
            @"The installation is really quite straightforward.
We have tons of wizards that do all the work for you. 
Have you read the installation instructions?";
         d["memory"] = @"If you read the system requirements carefully, 
you will see that the specified memory requirements 
are 1.5 gigabytes.  You really should upgrade your memory. 
Anything else you want to know?";
         d["linux"] = @"We take Linux support very seriously. 
But there are some problems.
Most have to do with incompatible glibc versions.
Can you be a bit more precise?";
         return d;
      }
   }
}
