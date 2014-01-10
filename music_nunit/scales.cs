using System;

namespace IntroCS
{
   class MainClass
   {
      // chunk-tones-begin
      static string[] tones = { "C", "C#", "D", "D#", "E", "F",
         "F#", "G", "G#", "A", "A#", "B" };
      // chunk-tones-end

      // chunk-findtone-begin
      static int FindTone(string key) {
         for (int i=0; i < tones.GetLength(0); i++) {
            if (key == tones[i])
               return i;
         }
         return -1;
      }
      // chunk-findtone-end


      // chunk-compute-begin
      static void ComputeScale(string key, int[] steps, int[] scale) {
         int tonePosition = 0;
         int startTone;

         startTone = FindTone(key);
         if (startTone < 0)
            return;
         if (steps.GetLength(0)+1 != scale.GetLength(0))
            return;
         tonePosition = startTone;
         for (int i=0; i < steps.GetLength(0); i++) {
            scale[i] = tonePosition % tones.GetLength(0);
            tonePosition += steps[i];
         }
      }
      // chunk-compute-end

      // chunk-write-begin
      static void WriteScale(int[] scale) {
         foreach (int i in scale) {
            Console.Write ("{0} ", tones[i]);
         }
         Console.WriteLine ();
      }
      // chunk-write-end


      // chunk-main-begin
      public static void Main (string[] args) 
      {
         int[] scale = new int[8]; 
         int[] major = { 2, 2, 1, 2, 2, 2, 1 };
         int[] minor = { 2, 1, 2, 2, 1, 2, 2 };

         string name = args[0];  // need command line tone name
         Console.WriteLine("{0} major scale", name);
         ComputeScale(name, major, scale);
         WriteScale(scale);
         Console.WriteLine("{0} minor scale", name);
         ComputeScale(name, minor, scale);
         WriteScale(scale);
      }
      // chunk-main-end
   }
}
