using FluentAssertions;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Texts
{
    [TestClass]
    public class IsEmptyTextTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueWithEmptyText()
        {
            //Arrange
            IsEmptyText subject = new IsEmptyText(new TextOf(""));

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseWithNotEmptyText()
        {
            //Arrange
            IsEmptyText subject = new IsEmptyText(new TextOf("any text"));

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }
    }
}