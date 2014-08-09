using System;

namespace IntroCS
{
   public class PrintTableExample
   {
     public static void PrintTable()
     {
        int[,] table = { {2, 4,  7, 55},
                         {3, 1,  8, 10},
                         {6, 0, 49, 12} };
        for (int r = 0; r < 3; r++) {
           for (int c = 0; c < 4; c++) {
              Console.Write("{0, 5}", table[r, c]);
           }
           Console.WriteLine();
        }
     }                          //end nested loop chunk

	  static void PrintTableAndSums(int[,] t)
	  {
	     int[] rowSum = new int[t.GetLength(0)],
	           colSum = new int[t.GetLength(1)];
	     int sum = 0;
	     for (int r = 0; r < t.GetLength(0); r++) {
	        for (int c = 0; c < t.GetLength(1); c++) {
	           rowSum[r] += t[r, c];
	           colSum[c] += t[r, c];
	        }
	        sum += rowSum[r];
	     }
	     int width = (""+sum).Length;
	     foreach (int n in t) {
	        width = Math.Max(width, (""+n).Length);
	     }
	     foreach (int n in colSum) {
	        width = Math.Max(width, (""+n).Length);
	     }
	     foreach (int n in rowSum) {
	        width = Math.Max(width, (""+n).Length);
	     }
        string format = "{0," + width + "} ";
	       
	     for (int r = 0; r < t.GetLength(0); r++) {
	        for (int c = 0; c < t.GetLength(1); c++) {
	           Console.Write(format, t[r, c]);
	        }
	        Console.WriteLine("| " + format, rowSum[r]);
	     }   
	     Console.WriteLine(StringOfReps("-",(width+1)*(t.GetLength(1)+1) + 1));
	     for (int c = 0; c < t.GetLength(1); c++) {
	        Console.Write(format, colSum[c]);
	     }
	     Console.WriteLine("| " + format, sum);
	  }
                                         // end of print with siums chunk
     /// Return s repeated n times. 
     static string StringOfReps(string s, int n)
     {
        string ret = "";
        for (int i = 0; i < n; i++) {
           ret += s;
        }
        return ret;
     }

     public static void Main()
     {
         PrintTable();
         Console.WriteLine();
         int[,] a = { {2, 4,  7, 55},
                      {3, 1,  8, 10},
                      {6, 0, 49, 12} };
         PrintTableAndSums(a);
     }
	}
}

