using GeoCoordinatePortable;

namespace AdProvider.External
{
    internal interface ILocationProvider
    {
        GeoCoordinate GetLocation();
    }
}
