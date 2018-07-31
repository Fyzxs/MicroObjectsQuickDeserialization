using FluentAssertions;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Texts
{
    [TestClass]
    public class TextOfTests
    {
        [TestMethod]
        public void ShouldReturnValueAsString()
        {
            //arrange
            string expected = "any string";
            TextOf subject = new TextOf(expected);

            //act
            string actual = subject;

            //assert
            actual.Should().Be(expected);
        }
    }

}