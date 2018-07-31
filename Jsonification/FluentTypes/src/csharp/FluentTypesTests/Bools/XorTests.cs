using FluentAssertions;
using FluentTypes.Bools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Bools
{
    [TestClass]
    public class XorTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseForTrueTrue()
        {
            //Arrange
            Bool subject = new Xor(Bool.True, Bool.True);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueForTrueFalse()
        {
            //Arrange
            Bool subject = new Xor(Bool.True, Bool.False);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueForFalseTrue()
        {
            //Arrange
            Bool subject = new Xor(Bool.False, Bool.True);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseForFalseFalse()
        {
            //Arrange
            Bool subject = new Xor(Bool.False, Bool.False);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }
    }
}