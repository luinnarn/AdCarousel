using System;

namespace AdProvider.External
{
    internal class MockClock : IClock
    {
        private DateTime _now = DateTime.Now;

        public DateTime Now() => _now = _now.AddMinutes(30);
    }
}
