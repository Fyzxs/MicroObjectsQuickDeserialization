using FluentAssertions;
using FluentTypes.Bools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentTypesTests.Bools
{
    [TestClass]
    public class AndTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTrueForTrueTrue()
        {
            //Arrange
            Bool subject = new And(Bool.True, Bool.True);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeTrue();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseForTrueFalse()
        {
            //Arrange
            Bool subject = new And(Bool.True, Bool.False);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseForFalseTrue()
        {
            //Arrange
            Bool subject = new And(Bool.False, Bool.True);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnFalseForFalseFalse()
        {
            //Arrange
            Bool subject = new And(Bool.False, Bool.False);

            //Act
            bool actual = subject;

            //Assert
            actual.Should().BeFalse();
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldShortCircuit()
        {
            //Arrange
            Bool subject = new And(Bool.False, new ExplodingBool());

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