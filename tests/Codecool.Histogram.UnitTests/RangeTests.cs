using System.Collections;
using NUnit.Framework;

namespace Codecool.Histogram.UnitTests
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void IsInRange_WhenCalled_ShouldReturnProperResult(int from, int to, string wordToTest, bool expectedValue)
        {
            Range range = new Range(from, to);
            bool actualValue = range.IsInRange(wordToTest);

            Assert.AreEqual(expectedValue, actualValue);
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(1, 4, "the", true);
                yield return new TestCaseData(1, 4, "a", true);
                yield return new TestCaseData(1, 4, "test", true);
                yield return new TestCaseData(1, 4, "testtest", false).SetName("Special client");
            }
        }
    }
}
