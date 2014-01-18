using System;
using NUnit.Framework;

namespace IntroCS
{
   [TestFixture()]
   public class RationalUnitTests //example for Testing Chapter
   {
      // snip-ConstructorTest-begin
      [Test()]
      public void ConstructorTest()
      {
         Rational r = new Rational(3, 5);
         Assert.IsTrue(r.GetNumerator() == 3);
         Assert.IsTrue(r.GetDenominator() == 5);
         r = new Rational(3, -5);
         Assert.IsTrue(r.GetNumerator() == -3);
         Assert.IsTrue(r.GetDenominator() == 5);
         r = new Rational(6, 10);
         Assert.IsTrue(r.GetNumerator() == 3);
         Assert.IsTrue(r.GetDenominator() == 5);
         r = new Rational(125, 1);
         Assert.IsTrue(r.GetNumerator() == 125);
         Assert.IsTrue(r.GetDenominator() == 1);
      }
      // snip-ConstructorTest-end

      // snip-ParseTest-begin
      [Test()]
      public void ParseTest()
      {
         Rational r;
         r = Rational.Parse("-12/30");
         Assert.IsTrue(r.CompareTo(new Rational(-12, 30)) == 0);
         r = Rational.Parse("123");
         Assert.IsTrue(r.CompareTo(new Rational(123, 1)) == 0);
         r = Rational.Parse("1.125");
         Assert.IsTrue(r.CompareTo(new Rational(9, 8)) == 0);
         Assert.IsTrue(r.ToString().Equals("9/8"));
      }
      // snip-ParseTest-end

      // snip-BasicArithmeticTest-begin
      [Test()]
      public void BasicArithmeticTests() {
         Rational r, r1, r2;
         r1 = new Rational(47, 64);
         r2 = new Rational(-11, 64);

         r = r1.Add(r2);
         Assert.IsTrue(r.CompareTo(new Rational(36, 64)) == 0);

         r = r1.Subtract(r2);
         Assert.IsTrue(r.CompareTo(new Rational(58, 64)) == 0);

         r = r1.Multiply(r2);
         Assert.IsTrue(r.CompareTo(new Rational(47 * -11, 64 * 64)) == 0);

         r = r1.Divide(r2);
         Assert.IsTrue(r.CompareTo(new Rational(47, -11)) == 0);

         r = r1.Reciprocal();
         Assert.IsTrue(r.CompareTo(new Rational(64, 47)) == 0);

         r = r1.Negate();
         Assert.IsTrue(r.CompareTo(new Rational(-47, 64)) == 0);
      }
      // snip-BasicArithmeticTest-end

      // snip-BasicComparisonTests-begin

      [Test()]
      public void BasicComparisonTests() {
         Rational r1 = new Rational(-3, 6);
         Rational r2 = new Rational(2, 4);
         Rational r3 = new Rational(1, 2);
         Assert.IsTrue(r1.CompareTo(r2) < 0);
         Assert.IsTrue(r2.CompareTo(r1) > 0);
         Assert.IsTrue(r2.CompareTo(r3) == 0);
      }
      // snip-BasicComparisonTests-end

      // snip-BasicConversionTests-begin
      [Test()]
      public void ConversionTests() {
         Rational r1 = new Rational(3, 6);
         Rational r2 = new Rational(-3, 6);
         Rational r3 = new Rational(10, -2);

         Assert.IsTrue(r1.ToDecimal() == 0.5m);
         Assert.IsTrue(r2.ToDecimal() == -0.5m);
         Assert.IsTrue(r1.ToDouble() == 0.5); //.5 is stored exactly
         Assert.IsTrue(r2.ToDouble() == -0.5);
         Assert.IsTrue(r2.ToString() == "-1/2");
         Assert.IsTrue("" + r3 == "-5");  //implicit use of ToString

      }
      // snip-BasicConversionTests-end
   }
}

