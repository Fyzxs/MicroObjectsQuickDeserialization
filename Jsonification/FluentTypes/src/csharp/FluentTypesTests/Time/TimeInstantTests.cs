using System;
using FluentAssertions;
using FluentTypes.Time;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTypesTests.Time
{
    [TestClass]
    public class TimeInstantTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnCurrentTimeInstant()
        {
            //Arrange
            DateTime now = DateTime.Now;
            TimeInstant subject = new TestTimeInstant(now);

            //Act
            DateTime actual = subject;

            //Assert
            actual.Should().Be(now);
        }

        private class TestTimeInstant : TimeInstant
        {
            private readonly DateTime _value;
            public TestTimeInstant(DateTime value) => _value = value;

            protected override DateTime Value() => _value;
        }
    }
}