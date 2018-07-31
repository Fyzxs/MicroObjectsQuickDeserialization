using FluentAssertions;
using FluentTypes.Bools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentTypesTests.Bools
{
    [TestClass]
    public class NorTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueIfBothAreFalse()
        {
            //Arrange
            Nor subject = new Nor(Bool.False, Bool.False);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseIfFirstIsTrue()
        {
            //Arrange
            Nor subject = new Nor(Bool.True, Bool.False);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseIfSecondIsTrue()
        {
            //Arrange
            Nor subject = new Nor(Bool.False, Bool.True);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseIfBothAreTrue()
        {
            //Arrange
            Nor subject = new Nor(Bool.True, Bool.True);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldShortCircuit()
        {
            //Arrange
            Bool subject = new Nor(Bool.True, new ExplodingBool());

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        private sealed class ExplodingBool : Bool
        {
            protected override bool Value() => throw new Exception("Didn't short circuit");
        }
    }
}