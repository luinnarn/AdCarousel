using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdProvider.Model;

namespace AdProvider.Repository
{
    internal class AdvertisementRepositoryMock : IAdvertisementRepository
    {
        public Task<IList<Advertisement>> Read()
        {
            IList<Advertisement> advertisements = new List<Advertisement> 
            {
                new Advertisement("Product 1", new TimeOfDayRule(TimeSpan.FromHours(16), TimeSpan.FromHours(3))),
                new Advertisement("Product 2", new TimeOfDayRule(TimeSpan.FromHours(10), TimeSpan.FromHours(6))),
                new Advertisement("Product 3", new TimeOfDayRule(TimeSpan.FromHours(17), TimeSpan.FromHours(6)))
            };

            return Task.FromResult(advertisements);
        }
    }
}
