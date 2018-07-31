using FluentAssertions;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Texts
{
    [TestClass]
    public class ReplaceTextTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldFormatTextIntoString()
        {
            //Arrange
            ReplaceText subject = new ReplaceText(new TextOf("any text ##Name##"), new TextOf("##Name##"), new TextOf("Peg"));

            //Act
            string actual = subject;

            //Assert
            actual.Should().Be("any text Peg");
        }
    }
}