using FluentAssertions;
using FluentTypes.ByteArrays;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Texts
{
    [TestClass]
    public class ByteArrayToLowercaseHexTextTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldTurnByteArrayIntoLowercaseHexString()
        {
            //Arrange
            ByteArray bytearray = new ByteArrayOf(new byte[] {0x42, 0x1d, 0xFA});
            ByteArrayToLowercaseHexText subject = new ByteArrayToLowercaseHexText(bytearray);

            //Act
            string actual = subject;

            //Assert
            actual.Should().Be("421dfa");
        }

        [TestMethod, TestCategory("unit")]
        public void ShouldTurnEmptyByteArrayIntoEmptyString()
        {
            //Arrange
            ByteArray bytearray = new ByteArrayOf(new byte[] {});
            ByteArrayToLowercaseHexText subject = new ByteArrayToLowercaseHexText(bytearray);

            //Act
            string actual = subject;

            //Assert
            actual.Should().Be("");
        }
    }
}