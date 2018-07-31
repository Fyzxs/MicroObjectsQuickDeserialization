using FluentAssertions;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Texts
{
    [TestClass]
    public class AreEqualTextTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueIfEqual()
        {
            //Arrange
            Text text1 = new TextOf("value");
            Text text2 = new TextOf("value");
            AreEqualText subject = new AreEqualText(text1, text2);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseIfNotEqual()
        {
            //Arrange
            Text text1 = new TextOf("value");
            Text text2 = new TextOf("not value");
            AreEqualText subject = new AreEqualText(text1, text2);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }
    }
}