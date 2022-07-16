using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Codewars.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/545cedaa9943f7fe7b000048
    /// </summary>
    public static class DetectPangramKata
    {
        public static bool IsPangram(string str)
        {
            var alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            var dict = new Dictionary<char, int>();

            foreach (var c in alphabetUpper)
            {
                dict.Add(c, 0);
            }
                   
            foreach (var c in str)
            {
                if (char.IsLetter(c) && dict.ContainsKey(char.ToUpper(c)))
                {
                    dict[char.ToUpper(c)]++;
                }
            }

            return dict.All(x => x.Value > 0);
        }
    }
    
    [TestFixture]
    public class DetectPangramTests
    {
        [Test]
        public void SampleTests() 
        {
            Assert.AreEqual(true, DetectPangramKata.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
    }
}
