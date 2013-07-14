using System;
using NUnit.Framework;

namespace IntroCS
{
   [TestFixture()]
   public class g_c_d_euclid_recursive_UnitTests
   {
      [Test()]
      public void ZeroTest()
      {
         Assert.AreEqual(GCDEuclidRecursive.GreatestCommonDivisor(5, 0),  5);
      }

      [Test()]
      public void BasicTest()
      {
         Assert.AreEqual(GCDEuclidRecursive.GreatestCommonDivisor(10, 5), 5);
         Assert.AreEqual(GCDEuclidRecursive.GreatestCommonDivisor(5, 10), 5);
      }
   }
}

