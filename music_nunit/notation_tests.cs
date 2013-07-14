using System;
using NUnit.Framework;

namespace IntroCS
{
   [TestFixture()]
	public class NoteTests
   {
      [Test()]
      public void TestConstructor()
      {
         Note n = new Note(0, 0, new Rational(1, 4));
         Rational r = n.GetDuration();
         Assert.IsTrue(r.CompareTo(new Rational(1, 4)) == 0);
      }
   }

   [TestFixture()]
   public class MeasureTests
   {
      [Test()]
      public void TestAdditionOfNotes()
      {
         // Create a measure in 3/4 time.
         Measure m = new Measure(new Rational(3, 4));
         Note q = new Note(0, 0, new Rational(1, 4));
         bool ok;
         ok = m.AddNote(q);
         Assert.IsTrue(ok);
         Assert.IsTrue( m.Length().CompareTo(new Rational(1, 4)) == 0 );

         ok = m.AddNote(q);
         Assert.IsTrue(ok);
         Assert.IsTrue( m.Length().CompareTo(new Rational(2, 4)) == 0 );

         ok = m.AddNote(q);
         Assert.IsTrue(ok);
         Assert.IsTrue( m.Length().CompareTo(new Rational(3, 4)) == 0 );

         // This last addition should *not* be ok and should not change the length from 3/4 to anything else.
         ok = m.AddNote(q);
         Assert.IsFalse(ok);
         Assert.IsTrue( m.Length().CompareTo(new Rational(3, 4)) == 0 );
      }
   }

   [TestFixture()]
   public class ScaleTests
   {
      [Test()]
      public void TestScaleGeneration() {
         Scale cscale = new Scale("C", Scale.ScaleTypes.Major);
         int[] cintervals = { 0, 2, 4, 5, 7, 9, 11, 0 };
         for (int i=0; i < 8; i++)
            Assert.AreEqual(cscale.GetTone(i), cintervals[i]);

         Scale dscale = new Scale("D", Scale.ScaleTypes.Major);
         int[] dintervals = { 2, 4, 6, 7, 9, 11, 1, 2 };
         //dscale.Output();
         for (int i=0; i < 8; i++) {
            //Console.WriteLine("i={0} actual={1} expected={2}", i, dscale.GetTone(i), dintervals[i]);
            Assert.AreEqual(dscale.GetTone(i), dintervals[i]);
         }
      }
   }

   [TestFixture()]
   public class ScoreTests
   {
      [Test()]
      public void TestScoreBasic() {
         Scale cscale = new Scale("C", Scale.ScaleTypes.Major);
         Score score = new Score(new Rational(4, 4), cscale, new string[] { "Piano", "S", "A", "T", "B" });
         score.AddMeasures(3);
         int[] yankee = { 0, 0, 2, 4, 0, 4, 2 };
         Rational[] durations = { new Rational(1, 4), new Rational(1, 4),
            new Rational(1, 4), new Rational(1, 4), new Rational(1, 4),
            new Rational(1, 4), new Rational(2, 4) };

         int item = 0;
         for (int measure=0; measure < 3; measure++) {
            bool ok = false;
            do {
               if (item < yankee.Length) {
                  ok = score.AddNote("Piano", measure, new Note(yankee[item], 0, durations[item]));
                  if (ok) {
                     //Console.WriteLine("Added note {0} to measure {1}", yankee[item], measure);
                     item++;
                  }
               } else
                  break;
            } while(ok);
         }

         // There should only be 2 of 3 measures full
         // measure one contains (C, 1/4) (C, 1/4), (D, 1/4), (E, 1/4)

         Measure m0 = score.GetMeasure("Piano", 0);
         Note m0n0 = m0.GetNote(0);
         Note m0n1 = m0.GetNote(1);
         Note m0n2 = m0.GetNote(2);
         Note m0n3 = m0.GetNote(3);

         Assert.IsTrue(m0n0.GetTone() == yankee[0] && m0n0.GetDuration().CompareTo(durations[0]) == 0);
         Assert.IsTrue(m0n1.GetTone() == yankee[1] && m0n1.GetDuration().CompareTo(durations[1]) == 0);
         Assert.IsTrue(m0n2.GetTone() == yankee[2] && m0n2.GetDuration().CompareTo(durations[2]) == 0);
         Assert.IsTrue(m0n3.GetTone() == yankee[3] && m0n3.GetDuration().CompareTo(durations[3]) == 0);

         // measure two contains (C, 1/4) (E, 1/4), (D, 1/2)
         Measure m1 = score.GetMeasure("Piano", 1);
         Note m1n0 = m1.GetNote(0);
         Note m1n1 = m1.GetNote(1);
         Note m1n2 = m1.GetNote(2);

         Assert.IsTrue(m1n0.GetTone() == yankee[4] && m1n0.GetDuration().CompareTo(durations[4]) == 0);
         Assert.IsTrue(m1n1.GetTone() == yankee[5] && m1n1.GetDuration().CompareTo(durations[5]) == 0);
         Assert.IsTrue(m1n2.GetTone() == yankee[6] && m1n2.GetDuration().CompareTo(durations[6]) == 0);

         // measure three is empty

         Measure m2 = score.GetMeasure("Piano", 2);
         Assert.IsTrue(m2.Length().CompareTo(new Rational(0, 1)) == 0);

      }
   }
}

