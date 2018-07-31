using FluentAssertions;
using FluentTypes.Exceptions;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentTypesTests.Texts
{
    [TestClass]
    public class NullTextTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldExplode()
        {
            //Arrange
            Text ignored = Text.NullObject;

            //Act
            Action action = () => new NullText();

            //Assert
            action.Should().Throw<NullObjectInstantiationException>();
        }
    }
}