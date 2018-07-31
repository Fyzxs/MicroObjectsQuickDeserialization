using FluentAssertions;
using FluentTypes.Bools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Bools
{
    [TestClass]
    public class NotTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseWithTrueInput()
        {
            //Arrange
            Bool expected = Bool.True;
            Not subject = new Not(expected);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueWithFalseInput()
        {
            //Arrange
            Bool expected = Bool.False;
            Not subject = new Not(expected);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }
    }
}