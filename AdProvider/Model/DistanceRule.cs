using AdProvider.External;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdProvider.Model
{
    class DistanceRule : IRule
    {
        private GeoCoordinate _coordinates;
        private double _distance;

        public DistanceRule(GeoCoordinate coordinates, double distance)
        {
            _coordinates = coordinates;
            _distance = distance;
        }

        public bool ShouldShowAd(Context context)
        {
            return context.Coordinates.GetDistanceTo(_coordinates) < _distance;
        }
    }
}
