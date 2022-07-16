using NUnit.Framework;

namespace Codewars.Katas
{
    public static class MultiplesOf3Or5Kata
    {
        public static int Solution(int value)
        {
            if (value < 0) return 0;

            int result = 0;
            
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            
            return result;
        }
    }
    
    [TestFixture]
    public class MultiplesOf3Or5Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, MultiplesOf3Or5Kata.Solution(10));
        }
    }
}