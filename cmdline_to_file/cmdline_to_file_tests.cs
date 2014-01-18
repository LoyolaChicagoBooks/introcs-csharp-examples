using System;
using System.IO;
using NUnit.Framework;

namespace IntroCS
{
   [TestFixture()]
   public class CmdlineToFileTests
   {
      [Test()]
      public void MainTest()
      {
         string f = "hello.txt", contents = "Hello, world!";
         FileTest.Main (new string[] { f, contents });
         StreamReader fin = new StreamReader (f);
         string s = fin.ReadToEnd();
         fin.Close ();
         Assert.IsTrue(s==contents);
      }
   }
}

