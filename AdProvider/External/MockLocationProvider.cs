using System.Collections.Generic;
using GeoCoordinatePortable;

namespace AdProvider.External
{
    internal class MockLocationProvider : ILocationProvider
    {
        private static int _counter;

        private static readonly IList<GeoCoordinate> Candidates = new List<GeoCoordinate> {
            new GeoCoordinate(45.255171, 19.844307),
            new GeoCoordinate(45.254113, 19.853164),
            new GeoCoordinate(45.252394, 19.862066)
        };

        public GeoCoordinate GetLocation() => Candidates[_counter++ % Candidates.Count];
    }
}
