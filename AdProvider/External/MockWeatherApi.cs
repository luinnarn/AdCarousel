using System;
using System.Threading.Tasks;
using AdProvider.Model;
using GeoCoordinatePortable;

namespace AdProvider.External
{
    internal class MockWeatherApi : IWeatherApi
    {
        private readonly Random _random = new Random();

        public Task<Weather> GetWeatherFor(GeoCoordinate geoCoordinate)
            => Task.FromResult(new Weather(20f + (float)_random.NextDouble() * 20));
    }
}
