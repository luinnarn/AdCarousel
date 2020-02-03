using GeoCoordinatePortable;
using System;

namespace AdProvider.Model
{
    public class Context
    {
        public Context(DateTime time, GeoCoordinate location, Weather weather)
        {
            Time = time;
            Coordinates = location;
            Weather = weather;
        }
        public DateTime Time { get; }

        public GeoCoordinate Coordinates { get; }

        public Weather Weather { get; }
    }
}
