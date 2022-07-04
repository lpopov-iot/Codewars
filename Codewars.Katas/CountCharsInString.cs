using NUnit.Framework;

namespace Codewars.Katas
{
    public static class CountCharsInStringKata
    {
        public static Dictionary<char, int> Count(string str)
        {
            var countDict = new Dictionary<char, int>();
            
            for (var i = 0; i < str.Length; i++)
            {
                var c = str[i];

                if (!countDict.TryAdd(c, 1))
                {
                    countDict[c]++;
                }
            }
            
            return countDict;
        }
    }
    
    [TestFixture]
    public class CountCharsInStringTests
    {
        [Test]
        public static void FixedTest_aaaa()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.AreEqual(d, CountCharsInStringKata.Count("aaaa"));
        }
  
        [Test]
        public static void FixedTest_aabb()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.AreEqual(d, CountCharsInStringKata.Count("aabb"));
        }
    }
}
