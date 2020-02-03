using System;

namespace AdProvider.Model
{
    public class WeatherRule : IRule
    {
        private Weather _weather;

        public WeatherRule(Weather weather)
        {
            _weather = weather;
        }

        public bool ShouldShowAd(Context context)
        {
            return Math.Abs(_weather.Temperature - context.Weather.Temperature) < 7;
        }
    }
}
