using FluentAssertions;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Texts
{
    [TestClass]
    public class AppendTextTexts
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldAppendSuffixToEndOfOrigin()
        {
            //Arrange
            AppendText subject = new AppendText(new TextOf("Any origin "), new TextOf("any suffix"));

            //Act
            string actual = subject;

            //Assert
            actual.Should().Be("Any origin any suffix");
        }
    }
}