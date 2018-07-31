using System;
using FluentAssertions;
using FluentTypes.Time;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Time
{
    [TestClass]
    public class TimeIntervalTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTimeIntervalAsTimeSpan()
        {
            //Arrange
            TimeSpan expectedTimeSpan = TimeSpan.FromMinutes(10);
            TimeInterval subject = new TestTimeInterval(expectedTimeSpan);

            //Act
            TimeSpan actual = subject;

            //Assert
            actual.Should().Be(expectedTimeSpan);
        }

        private class TestTimeInterval : TimeInterval
        {
            private readonly TimeSpan _value;

            public TestTimeInterval(TimeSpan value) => _value = value;

            protected override TimeSpan Value() => _value;
        }
    }
}