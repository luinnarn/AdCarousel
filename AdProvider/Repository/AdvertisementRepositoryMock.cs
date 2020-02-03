using AdProvider.Model;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdProvider.Repository
{
    internal class AdvertisementRepositoryMock : IAdvertisementRepository
    {

        public Task<IEnumerable<Advertisement>> Read()
        {
            IEnumerable<Advertisement> advertisements = new List<Advertisement>
            {
                new Advertisement("Product 1", new TimeOfDayRule( TimeSpan.FromHours(16), TimeSpan.FromHours(3))),
                new Advertisement("Product 2", new DayOfMonthRule( 30)),
                new Advertisement("Product 3", new WeekendRule( false)),
                new Advertisement("Product 4", new StrictCompositeRule(new List<IRule>(){
                    new WeekendRule( false),
                    new DayOfMonthRule( 28),
                    new TimeOfDayRule( TimeSpan.FromHours(16), TimeSpan.FromHours(3)) })),
                new Advertisement("Product E", new DistanceRule(new GeoCoordinate(45.255143, 19.844361),  1000)),
//                new Advertisement("")
            };

            return Task.FromResult(advertisements);
        }
    }
}
