using AdProvider.External;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdProvider.Model
{
    public class DayOfMonthRule : IRule

    {
        public DayOfMonthRule(int dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
        }
        public int DayOfMonth { get; set; }

        public bool ShouldShowAd(Context context)
        {
            return context.Time.Day == DayOfMonth;
        }
    }
}
