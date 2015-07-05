using System;
namespace IntroCS
{
/// class used twice in Clock
   class RolloverCounter
   {
      private int limit, count;

      public RolloverCounter(int limit)
      {
         this.limit = limit;
         count = 0;  //for clarity - this is the default value
      }

      public int GetCount()
      {
         return count;
      }

      public void SetCount(int count)
      {
         this.count = count;
      }

      /// advance by one time tick
      /// eventually roll over at limit
      public void Advance()
      {
         count = (count + 1) % limit;
      }
   }
}
