using System;

namespace IntroCS
{
   class WordSearchPuzzle
   {
      public static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

      public static void GenerateWordSearch(char[,] puzzle, string[] words) {

         int width = puzzle.GetLength (0);
         int height = puzzle.GetLength (1);
         Random r = new Random();

         foreach (string word in words) {

            // pick a random orientation for the word
            // 0 = across, 1 = down, 2 = diagonal

            // possible exercise for students to reverse the word before inserting. :-)

            bool wordInserted = false;
            while (!wordInserted) {
               int x = r.Next (0, width);
               int y = r.Next (0, height);
               int orientation = r.Next (0, 3);
               string wordAsUppercase = word.ToUpper();
               Console.WriteLine ("Attempting to insert word {0} at [{1},{2}]", wordAsUppercase, x, y);
               if (orientation == 0)
                  wordInserted = InsertAcross(puzzle, x, y, wordAsUppercase);
               else if (orientation == 1)
                  wordInserted = InsertDown(puzzle, x, y, wordAsUppercase);
               else if (orientation == 2)
                  wordInserted = InsertDiagonal(puzzle, x, y, wordAsUppercase);
            }
          }
      }

      // Across means on dimension 1 (y)
      public static bool InsertAcross(char[,] puzzle, int x, int y, string word) {
         // check whether all of the positions are '.' or match the letter at the position
         if (y + word.Length > puzzle.GetLength(1))
            return false;

         for (int i=0; i < word.Length; i++) {
            if (puzzle[x, y+i] == '.')
               continue;
            else if (puzzle[x, y+i] == word[i])
               continue;
            else {
               return false;
            }
         }

         // Now we know it can fit so we can insert it into the game.

         for (int i=0; i < word.Length; i++) {
            Console.WriteLine ("x={0}, pos={1}", x, i);
            puzzle[x, y+i] = word[i];
         }

         return true;
      }


      public static bool InsertDown(char[,] puzzle, int x, int y, string word) {
         // check whether all of the positions are '.' or match the letter at the position
         if (x + word.Length >= puzzle.GetLength(0))
            return false;

         for (int i=0; i < word.Length; i++) {
            if (puzzle[x+i, y] == '.')
               continue;
            else if (puzzle[x+i, y] == word[i])
               continue;
            else {
               return false;
            }
         }

         // Now we know it can fit so we can insert it into the game.

         for (int i=0; i < word.Length; i++) {
            puzzle[x+i, y] = word[i];
         }

         return true;
      }

      public static bool InsertDiagonal(char[,] puzzle, int x, int y, string word) {
         // check whether all of the positions are '.' or match the letter at the position
         if (x + word.Length >= puzzle.GetLength(0) || y+word.Length >= puzzle.GetLength(1))
            return false;

         for (int i=0; i < word.Length; i++) {
            if (puzzle[x+i, y+i] == '.')
               continue;
            else if (puzzle[x+i, y+i] == word[i])
               continue;
            else {
               return false;
            }
         }

         // Now we know it can fit so we can insert it into the game.

         for (int i=0; i < word.Length; i++) {
            puzzle[x+i, y+i] = word[i];
         }

         return true;
      }

      /// Insert word if possible starting at
      /// (x, y),  moving in dirrction (dx, dy).
      /// Return true if the change succeeds. 
      public static bool Insert(char[,] puzzle, int x, int y,
                                int dx, int dy, string word) {
         // check whether all of the positions are '.' or match the letter at the position
         if (x + word.Length*dx > puzzle.GetLength(0) ||
             y + word.Length*dy > puzzle.GetLength(1))
            return false;

         for (int i=0; i < word.Length; i++) {
            char ch = puzzle[x+i*dx, y+i*dx];
            if (ch != '.' && ch != word[i]) {
               return false;
            }
         }

         // Now we know it can fit so we can insert it into the game.
         for (int i=0; i < word.Length; i++) {
            Console.WriteLine ("({0}, {1}): {2}", x, y, word[i]);
            puzzle[x, y] = word[i];
            x += dx;
            y += dy;
         }

         return true;
      }



      public static void ClearWordSearch(char [,] puzzle) {
         for (int x=0; x < puzzle.GetLength(0); x++)
            for (int y=0; y < puzzle.GetLength(1); y++)
               puzzle[x,y] = '.';

      }

      public static void PrintWordSearch(char [,] puzzle) {
         for (int x=0; x < puzzle.GetLength (0); x++) {
            for (int y=0; y < puzzle.GetLength(1); y++) {
               Console.Write ("{0} ",puzzle[x,y]);
            }
            Console.WriteLine ();
         }
      }

      public static void FillWordSearch(char[,] puzzle)  {
         Random r = new Random();

         for (int x=0; x < puzzle.GetLength(0); x++)
            for (int y=0; y < puzzle.GetLength(1); y++)
               if (puzzle[x, y] == '.')
                  puzzle[x, y] = Alphabet[r.Next() % Alphabet.Length];

      }

      public static void Main (string[] args)
      {
         char [,] puzzle = new char[10, 12];
         string[] words = new string[] { "this", "word", "search", "program", "is", "gonna", "rock",
           "but", "it", "is", "coming", "slowly"};

         Console.WriteLine ("Dimension 0 = {0}, 1 = {1}", puzzle.GetLength (0), puzzle.GetLength (1));
         Console.WriteLine ("Creating empty word search.");
         ClearWordSearch(puzzle);

         Console.WriteLine ("This should be dots only.");
         PrintWordSearch (puzzle);

         Console.WriteLine ("Generating Word search.");
         GenerateWordSearch(puzzle, words);

         Console.WriteLine ("Printing word search");
         PrintWordSearch(puzzle);

         Console.WriteLine ("Filling in rest of word search with randomness");
         FillWordSearch(puzzle);

         Console.WriteLine ("Final word search");
         PrintWordSearch (puzzle);
      }
   }
}
