using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Codewars.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/52761ee4cffbc69732000738/train/csharp
    /// </summary>
    public static class GoodVsEvilKata
    {
        private const string ResultString = "Battle Result: ";
        
        private const string GoodWinString = "Good triumphs over Evil";
        private const string EvilWinString = "Evil eradicates all trace of Good";
        private const string DrawString = "No victor on this battle field";

        public static string GoodVsEvil(string good, string evil)
        {
            var goodWorth = new List<int>{ 1, 2, 3, 3, 4, 10 };
            var evilWorth = new List<int>{ 1, 2, 2, 2, 3, 5, 10 };

            var goodResult = good.Split(' ').Select((x, i) => int.Parse(x) * goodWorth[i]).Sum();
            var evilResult = evil.Split(' ').Select((x, i) => int.Parse(x) * evilWorth[i]).Sum();

            if (goodResult > evilResult) return ResultString + GoodWinString; 
            if (evilResult > goodResult) return ResultString + EvilWinString;
            if (evilResult == goodResult) return ResultString + DrawString;

            return string.Empty;
        }
    }
    
    [TestFixture]
    public class GoodVsEvilTests
    {
        [Test]
        public static void EvilShouldWin()
        {
            Assert.AreEqual("Battle Result: Evil eradicates all trace of Good", GoodVsEvilKata.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
        }
  
        [Test]
        public static void GoodShouldTriumph()
        {
            Assert.AreEqual("Battle Result: Good triumphs over Evil", GoodVsEvilKata.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
        }
  
        [Test]
        public static void ShouldBeATie()
        {
            Assert.AreEqual("Battle Result: No victor on this battle field", GoodVsEvilKata.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));
        }
    }
}