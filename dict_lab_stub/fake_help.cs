using System;
using System.IO;
using System.Collections.Generic;

namespace IntroCS
{
   class FakeHelp
   {
      static Random rand = new Random();

      public static void Main()
      {
         StreamReader reader = FIO.OpenReader("help_not_defaults.txt");
         // special data is in the first two paragraphs
         string welcome = FileUtil.ReadParagraph(reader);
         string goodbye = FileUtil.ReadParagraph(reader);
         List<string> guessList =                  // rest of the file gives a
                   FileUtil.GetParagraphs(reader); //  list of random responses
         reader.Close();

         reader = FIO.OpenReader("help_not_responses.txt");
         Dictionary<string, string> responses =
                                        FileUtil.GetDictionary(reader);
         reader.Close();

         Console.Write(welcome);
         string prompt = "\n> ";
         Console.WriteLine("Enter 'bye' to end our session.");
         string fromUser;
         do {
            fromUser = UI.PromptLine(prompt).ToLower().Trim();
            if (fromUser != "bye") {
               string answer = Response(fromUser, guessList, responses);
               Console.Write("\n" + answer);
            }
         } while (fromUser != "bye");
         Console.Write("\n"+ goodbye);
      }

      /// Take input fromUser and use guessList and responses to
      ///  determine and return a string response. 
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
   }
}
