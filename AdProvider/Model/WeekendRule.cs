using System;

namespace AdProvider.Model
{
    class WeekendRule : IRule
    {
        private bool _isWeekend;

        public WeekendRule(bool IsWeekend)
        {
            _isWeekend = IsWeekend;
        }

        public bool ShouldShowAd(Context context)
        {
            return _isWeekend && (context.Time.DayOfWeek == DayOfWeek.Saturday
                || context.Time.DayOfWeek == DayOfWeek.Sunday
                || context.Time.DayOfWeek == DayOfWeek.Friday);
        }
    }
}
