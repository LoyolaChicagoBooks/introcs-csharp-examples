using System;
namespace IntroCS
{
/// class with instance variables of another user class
   class Clock
   {
      private RolloverCounter hours, minutes;

      /// new Clock set to midnight
      public Clock()
      {
         hours = new RolloverCounter(24);
         minutes = new RolloverCounter(60);
      }

      ///  new Clock set to specified time
      public Clock(int nHours, int nMinutes)
      {
         hours = new RolloverCounter(24);
         minutes = new RolloverCounter(60);
         SetTime (nHours, nMinutes);
      }

      public void SetTime(int nHours, int nMinutes)
      {
         hours.SetCount(nHours);
         minutes.SetCount(nMinutes);
      }

      /// advance by one time tick
      public void Tick()
      {
         minutes.Advance();
         if (minutes.GetCount() == 0) {
            hours.Advance();
         }
      }

      /// Always 2 digits for both hours and minute with colon in middle
      public string GetTimeString()
      {
         return string.Format("{0:D2}:{1:D2}",
            hours.GetCount(), minutes.GetCount());
      }
   }
}
