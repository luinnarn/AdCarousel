using System;

namespace AdProvider.Model
{
    internal class TimeOfDayRule : Rule
    {
        public TimeOfDayRule(TimeSpan startTime, TimeSpan duration)
        {
            StartTime = startTime;
            Duration = duration;
        }

        public TimeSpan StartTime { get; }
        
        public TimeSpan Duration { get; }
    }
}
