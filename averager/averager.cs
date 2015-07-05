using System;
namespace IntroCS
{
/// a class that is more than a container
   class Averager
   {
      private int dataCount;
      private double sum;

      /// new Averager with no data
      public Averager()
      {
         Clear();
      }

      public void AddDatum(double value)
      {
         sum += value;
         dataCount++;
      }

      public int GetDataCount()
      {
         return dataCount;
      }

      /// Gets the average of the data
      ///   or NaN if no data.
      public double GetAverage()
      {
         return sum/dataCount;  // is NaN if dataCount is 0
      }

      public void Clear()
      {
         sum = 0.0;
         dataCount = 0;
      }

      public override string ToString ()
      {
         return string.Format("items: {0}; average: {1}",
                              GetDataCount(), GetAverage());
      }
   }
}
