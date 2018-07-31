using System.Text;
using FluentAssertions;
using FluentTypes.ByteArrays;
using FluentTypes.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.ByteArrays
{
    [TestClass]
    public class Utf8ByteArrayFromTextTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnArrayOfBytes()
        {
            //Arrange
            Text text = new TextOf("Brian");
            Utf8ByteArrayFromText subject = new Utf8ByteArrayFromText(text);

            //Act
            byte[] actual = subject;

            //Assert
            actual.Should().BeEquivalentTo(Encoding.UTF8.GetBytes("Brian"));
        }
    }
}