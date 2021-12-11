using NUnit.Framework;
using System.IO;

namespace Codecool.Histogram.UnitTests
{
    [TestFixture]
    public class TextReaderTests
    {
        [Test]
        public void Read_WhenFileNotExist_ThrowException()
        {
            const string fileName = "NotFound.txt";
            TextReader textReader = new TextReader(fileName);

            Assert.Throws<FileNotFoundException>(() => textReader.Read());
        }
    }
}
