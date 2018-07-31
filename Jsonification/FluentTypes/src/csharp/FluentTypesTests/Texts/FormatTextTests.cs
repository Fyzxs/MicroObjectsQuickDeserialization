using FluentAssertions;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Texts
{
    [TestClass]
    public class FormatTextTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldFormatTextIntoString()
        {
            //Arrange
            Text textToFormat = new TextOf("any text {0} {1}");
            FormatText subject = new FormatText(textToFormat, new TextOf("Brian"), new TextOf("Peg"));

            //Act
            string actual = subject;

            //Assert
            actual.Should().Be("any text Brian Peg");
        }
    }
}