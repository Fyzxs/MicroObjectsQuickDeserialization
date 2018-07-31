using FluentAssertions;
using FluentTypes.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Exceptions
{
    [TestClass]
    public class NullObjectInstantiationExceptionTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldHaveExpectedMessage()
        {
            //Arrange
            NullObjectInstantiationException subject = new NullObjectInstantiationException();

            //Act
            string actual = subject.Message;

            //Assert
            actual.Should().Be("Null Objects are allowed only one instantiation");
        }
    }
}