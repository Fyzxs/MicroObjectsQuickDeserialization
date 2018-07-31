using System;
using FluentAssertions;
using FluentTypes.Time;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Time
{
    [TestClass]
    public class NowTimeInstantTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnADateTimeCloseToNow()
        {
            //Arrange
            NowTimeInstant subject = new NowTimeInstant();

            //Act
            DateTime actual = subject;

            //Assert
            actual.Should().BeCloseTo(DateTime.Now, precision: 100);
        }
    }
}