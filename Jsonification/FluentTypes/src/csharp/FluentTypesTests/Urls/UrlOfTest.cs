using FluentAssertions;
using FluentTypes.Urls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FluentTypesTests.Urls
{
    [TestClass]
    public class UrlOfTest
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldCreateUri()
        {
            //Arrange
            string expectedUri = "https://whatever.com/";

            UrlOf subject = new UrlOf(expectedUri);

            //Act
            Uri actual = subject;

            //Assert
            actual.AbsoluteUri.Should().Be(expectedUri);
        }
    }
}