using System;
using Xunit;

using DateLib;

namespace Tests
{
    public class DateTests
    {
        private DateTime dateRef = new DateTime(2000, 1, 1, 0, 0, 0);

        [Fact]
        public void intervalBetweenDateTime_should_return_1_second()
        {
            var res = new TimeSpan(0, 0, 1);
            Assert.Equal(DateUtils.intervalBetweenDateTime(dateRef, dateRef.AddSeconds(1)), res);
        }

        //TODO formatword (4 tests)
    }
}
