using NUnit.Framework;

namespace Codewars.Katas
{
    public static class AreTheySameKata
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length == 0 || a.Length != b.Length)
            {
                return false;
            }

            return new HashSet<int>(a.Select(x => x*x)).SetEquals(b);
        }
    }
    
    [TestFixture]
    public class AreTheySameTests {

        [Test]
        public void Test1() {
            int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
            bool r = AreTheySameKata.comp(a, b);
            Assert.AreEqual(true, r);
        }
        
        [Test]
        public void Test2() {
            int[] a = new int[] {};
            int[] b = new int[] {};
            bool r = AreTheySameKata.comp(a, b);
            Assert.AreEqual(false, r);
        }
        
        [Test]
        public void Test3() {
            int[] a = null;
            int[] b = null;
            bool r = AreTheySameKata.comp(a, b);
            Assert.AreEqual(false, r);
        }
    }
}
