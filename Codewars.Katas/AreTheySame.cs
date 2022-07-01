using System;
using NUnit.Framework;

namespace Codewars.Katas
{
    public static class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            // your code
            return true;
        }
    }
    
    [TestFixture]
    public class AreTheySameTests {

        [Test]
        public void Test1() {
            int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(true, r);
        }
    }
}
