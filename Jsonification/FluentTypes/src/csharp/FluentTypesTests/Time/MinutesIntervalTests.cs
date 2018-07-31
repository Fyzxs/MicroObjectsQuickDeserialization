using System;
using FluentTypes.Time;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Time
{
    [TestClass]
    public class MinutesIntervalTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnATimeSpanGivenANumberOfMinutes()
        {
            //Arrange
            TimeSpan expectedTime = TimeSpan.FromSeconds(60);
            MinutesInterval subject = new MinutesInterval(1.0);

            //Act
            MinutesInterval actual = subject;

            //Assert
            Assert.AreEqual(expectedTime, actual);
        }
    }
}