using System.Text;
using NUnit.Framework;

namespace Codewars.Katas
{
    public static class BreakCamelCaseKata
    {
        public static string BreakCamelCase(string str)
        {
            var sb = new StringBuilder();
            for (var i = -1; i < str.Length - 1; i++)
            {
                var nextChar = str[i+1];
                if (char.IsUpper(nextChar))
                {
                    sb.Append($" {str[i+1]}");
                }
                else
                {
                    sb.Append(str[i+1]);
                }
            }

            return sb.ToString();
        }
    }
    
    [TestFixture]
    public class BreakCamelCaseTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("camelCasing").Returns("camel Casing");
                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
            }
        }
  
        [Test, TestCaseSource("testCases")]
        public string Test(string str) => BreakCamelCaseKata.BreakCamelCase(str);
    }
}
