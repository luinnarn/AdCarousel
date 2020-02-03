using System;

namespace AdProvider.Model
{
    internal class TimeOfDayRule : IRule
    {
        public TimeOfDayRule(TimeSpan startTime, TimeSpan duration)
        {
            StartTime = startTime;
            Duration = duration;
        }

        public TimeSpan StartTime { get; }

        public TimeSpan Duration { get; }


        public bool ShouldShowAd(Context context)
        {
            return StartTime < context.Time.TimeOfDay &&
                   context.Time.TimeOfDay < StartTime + Duration;
        }
    }
}
