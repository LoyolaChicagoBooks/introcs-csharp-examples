using System;
using NUnit.Framework;

namespace IntroCS
{
   [TestFixture()]
   public class g_c_d_basic_UnitTests
   {
      [Test()]
      public void ZeroTest()
      {
         // Our basic GCD only works for a, b > 0
         // Assert.AreEqual(GCDBasic.GreatestCommonDivisor(5, 0),  5);
      }

      [Test()]
      public void BasicTest()
      {
         Assert.AreEqual(GCDBasic.GreatestCommonDivisor(5, 10),  5);
         Assert.AreEqual(GCDBasic.GreatestCommonDivisor(10, 5),  5);
      }
   }
}

