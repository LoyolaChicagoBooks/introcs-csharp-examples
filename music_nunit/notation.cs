using System;
using System.Collections.Generic;

namespace IntroCS
{
   public struct Note {

      private int tone;
      private int octave;
      private Rational duration;

      public Rational GetDuration() {
         return duration;
      }

      public int GetTone() {
         return tone;
      }

      public int GetOctave() {
         return octave;
      }

      public Note(int tone, int octave, Rational duration) {
         this.tone = tone;
         this.octave = octave;
         this.duration = duration;
      }
   }

   // Agile approach: Let's allow one voice per measure.

   public class Measure {
      private List<Note> voice;
      Rational duration;

      public Measure(Rational duration) {
         this.voice = new List<Note>();
         this.duration = duration;
      }

      public Rational Length() {
         Rational sum = new Rational(0, 1);
         foreach (Note n in voice) {
            sum = sum.Add(n.GetDuration());
         }
         return sum;
      }

      public bool AddNote(Note note) {
         Rational currentLength = Length();
         Rational newLength = currentLength.Add(note.GetDuration());
         if (newLength.CompareTo(duration) > 0)
            return false;
         else {
            voice.Add(note);
            return true;
         }
      }

      public Note GetNote(int position) {
         Note noNote = new Note(0, 0, new Rational(0, 0)); 
                       // a note with 0 tone, octave, duration 
         if (position <  voice.Count)
            return voice[position];
         else
            return noNote;
      }
   }

   // In this first version, we're going to support any base note in major or minor.

   public class Scale {

      public enum ScaleTypes { Major, Minor };

      private int [] scale;

      private static int[] MajorIntervals = { 2, 2, 1, 2, 2, 2, 1 };

      private static int[] MinorIntervals = { 2, 1, 2, 2, 1, 2, 2 };


      // chunk-tones-begin
      public static string[] tones = { "C", "C#", "D", "D#", "E", "F",
         "F#", "G", "G#", "A", "A#", "B" };
      // chunk-tones-end

      // chunk-findtone-begin
      public static int FindTone(string key) {
         for (int i=0; i < tones.GetLength(0); i++) {
            if (key == tones[i])
               return i;
         }
         return -1;
      }
      // chunk-findtone-end

      // chunk-compute-begin
      private static void ComputeScale(string key, int[] steps, int[] scale) {
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
         scale[scale.Length-1] = scale[0];
      }
      // chunk-compute-end

      public Scale(string key, ScaleTypes type) {
         scale = new int [8];
         if (type ==  ScaleTypes.Major)
            ComputeScale(key, MajorIntervals, scale);
         else if (type == ScaleTypes.Minor)
            ComputeScale(key, MinorIntervals, scale);
         else
            ComputeScale(key, MajorIntervals, scale);
      }

      // position is interpreted mod 8 (scale.Length).
      public int GetTone(int position) {
         return scale[position % scale.Length];
      }

      public void Output() {
         foreach (int i in scale) {
            Console.Write ("{0} ", tones[i]);
         }
         Console.WriteLine ();
      }

   }

   // We are starting with a fairly simple score structure that assumes the time/key signature never change.
   // Again we are taking an agile approach but will extend this later.

   // All staff labels (e.g. Piano, S, A, T, B) must be specified up front. Keep in mind that Piano must
   // be specified as PianoLine1 and PianoLine2 if you want both treble and bass clefs.

   public class Score {
      private Rational timeSignature;
      private Scale keySignature;

      private Dictionary<string, List<Measure>> staff;

      public Score(Rational timeSignature, Scale keySignature, string[] staffLabels) {
         this.timeSignature = timeSignature;
         this.keySignature = keySignature;
         staff = new Dictionary<string, List<Measure>>();
         foreach (string label in staffLabels) {
            staff[label] = new List<Measure>();
         }
      }

      // must add measure each time you want a new one. You can allocate all desired measures up front.
      // You can also add just one at a time. This method is completely re-entrant and simply appends "howMany"
      // measure objects for each staff line.
      public void AddMeasures(int howMany) {
         for (int i=0; i < howMany; i++) {
            foreach (var pair in staff) {
               List<Measure> measures = pair.Value;
               measures.Add(new Measure(timeSignature));
            }
         }
      }

      public bool AddNote(string label, int measureNumber, Note note) {
         // find the staff label of interest
         if (staff.ContainsKey(label)) {
            List<Measure> measures = staff[label];
            if (measureNumber < measures.Count) {
               Measure m = measures[measureNumber];
               return m.AddNote(note);
            }
         }
         return false;
      }

      public Measure GetMeasure(string label, int measureNumber) {
         if (staff.ContainsKey(label)) {
            List<Measure> measures = staff[label];
            if (measureNumber < measures.Count)
               return measures[measureNumber];
         }
         return null;
      }
   }

}
