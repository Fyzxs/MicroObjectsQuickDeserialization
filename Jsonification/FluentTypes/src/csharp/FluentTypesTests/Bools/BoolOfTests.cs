using FluentAssertions;
using FluentTypes.Bools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Bools
{
    [TestClass]
    public class BoolOfTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnBoolTypeOfTrue()
        {
            //Arrange
            bool expected = true;
            Bool subject = new BoolOf(expected);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().Be(expected);
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnBoolTypeOfFalse()
        {
            //Arrange
            bool expected = false;
            Bool subject = new BoolOf(expected);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().Be(expected);
        }
    }
}