using FluentAssertions;
using FluentTypes.ByteArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.ByteArrays
{
    [TestClass]
    public class ByteArrayOfTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnByteArray()
        {
            //Arrange
            byte[] expected = {0x42};
            ByteArrayOf subject = new ByteArrayOf(expected);

            //Act
            byte[] actual = subject;

            //Assert
            actual.Should().BeSameAs(expected);
        }
    }
}