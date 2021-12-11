using NUnit.Framework;
using System;
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

        [Test]
        public void Read_WhenFileIsEmpty_ShouldReturnEmptyString()
        {
            TextReader textReader = new TextReader("empty.txt");
            string fileValue = textReader.Read();

            Assert.AreEqual(String.Empty, fileValue);
        }

        [Test]

        public void Read_WhenTextIsOneLine_ShouldReturnContentAsString()
        {
            TextReader textReader = new TextReader("test.txt");
            string expectedValue = "Harry Potter and the Sorcerer's Stone";
            string fileValue = textReader.Read();

            Assert.AreEqual(expectedValue, fileValue);
        }

    }
}
