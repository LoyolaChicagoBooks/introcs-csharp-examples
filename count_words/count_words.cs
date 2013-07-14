using System;
using System.Collections.Generic;

namespace CountWords
{
   class CountWords
   {
      public static void Main(string[] args)
      {
         string[] ignoreAll = "a an and the".Split(' ');
         var ignore = new HashSet<string>(ignoreAll);
         string Gettysburg =
@"Four score and seven years ago our fathers brought forth on this
continent a new nation, conceived in liberty, and dedicated to the
proposition that all men are created equal.

Now we are engaged in a great civil war, testing whether that nation,
or any nation, so conceived and so dedicated, can long endure.
We are met on a great battle-field of that war.
We have come to dedicate a portion of that field, as a final resting
place for those who here gave their lives that that nation might live.
It is altogether fitting and proper that we should do this.

But, in a larger sense, we can not dedicate, we can not consecrate,
we can not hallow this ground. The brave men, living and dead,
who struggled here, have consecrated it, far above our poor power to
add or detract. The world will little note, nor long remember what
we say here, but it can never forget what they did here.
It is for us the living, rather, to be dedicated here to the unfinished
work which they who fought here have thus far so nobly advanced.
It is rather for us to be here dedicated to the great task remaining
before us—that from these honored dead we take increased devotion to that
cause for which they gave the last full measure of devotion—that we here
highly resolve that these dead shall not have died in vain—that this nation,
under God, shall have a new birth of freedom—and that government of the
people, by the people, for the people, shall not perish from the earth.";

         Dictionary<string, int> wc = GetCounts(Gettysburg, ignore);
         PrintCounts(wc, 3);
      }
      
                                                  // start chunk
      /// Return a Dictionary of word:count pairs from parsing s,
      ///  excluding all strings in ignore. 
      public static Dictionary<string, int> GetCounts(string s,
                                                      HashSet<string> ignore)
      {
         char[] sep = "\n\t !@#$%^&*()_+{}|[]\\:\";<>?,./".ToCharArray();
         string[] words = s.ToLower().Split(sep);
         ignore.Add(""); //generated from consecutive splitting characters
         var wc = new Dictionary<string, int>();
         foreach (string w in words) {
            if (!ignore.Contains(w)) {
               if (wc.ContainsKey(w)) { //increase count of word already seen
                  wc[w]++;
               }
               else {                   // make a first entry
                  wc[w] = 1;
               }
            }
         }
         return wc;
      }

      /// Print each word and its count, if the count is at least minCount. 
      public static void PrintCounts(Dictionary<string, int> wc, int minCount)
      {
         List<string> words = new List<string>(wc.Keys);
         words.Sort();
         foreach (string w in words) {
            if (wc[w] >= minCount) {
               Console.WriteLine("{0}: {1}", w, wc[w]);
            }
         }
      }
   }                                     // end chunk
}
