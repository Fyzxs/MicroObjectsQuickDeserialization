using FluentAssertions;
using FluentTypes.Bools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentTypesTests.Bools
{
    [TestClass]
    public class OrTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseIfBothAreFalse()
        {
            //Arrange
            Or subject = new Or(Bool.False, Bool.False);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueIfFirstIsTrue()
        {
            //Arrange
            Or subject = new Or(Bool.True, Bool.False);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueIfSecondIsTrue()
        {
            //Arrange
            Or subject = new Or(Bool.False, Bool.True);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueIfBothAreTrue()
        {
            //Arrange
            Or subject = new Or(Bool.True, Bool.True);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldShortCircuit()
        {
            //Arrange
            Bool subject = new Or(Bool.True, new ExplodingBool());

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        private sealed class ExplodingBool : Bool
        {
            protected override bool Value() => throw new Exception("Didn't short circuit");
        }
    }
}