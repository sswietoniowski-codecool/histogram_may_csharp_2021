using NUnit.Framework;

namespace Codecool.Histogram.UnitTests
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        [TestCase(1, 4, "the", true)]
        [TestCase(1, 4, "a", true)]
        [TestCase(1, 4, "test", true)]
        [TestCase(1, 4, "testtest", false)]
        public void IsInRange_WhenCalled_ShouldReturnProperResult(int from, int to, string wordToTest, bool expectedValue)
        {
            Range range = new Range(from, to);
            bool actualValue = range.IsInRange(wordToTest);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
