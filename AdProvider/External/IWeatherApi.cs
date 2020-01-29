using System.Threading.Tasks;
using AdProvider.Model;
using GeoCoordinatePortable;

namespace AdProvider.External
{
    internal interface IWeatherApi
    {
        Task<Weather> GetWeatherFor(GeoCoordinate geoCoordinate);
    }
}
