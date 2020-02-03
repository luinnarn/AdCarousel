using AdProvider.External;
using AdProvider.Model;
using AdProvider.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AdProvider
{
    public class AdProviderFacade : IDisposable
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        private readonly IAdvertisementRepository _advertisementRepository = new AdvertisementRepositoryMock();

        private readonly IClock _clock = new MockClock();
        private readonly ILocationProvider locationProvider = new MockLocationProvider();
        private readonly IWeatherApi weatherApi = new MockWeatherApi();

        public event EventHandler<IList<Advertisement>> ActiveAdvertisements;

        public AdProviderFacade()
        {
            Task.Run(ProcessAdvertisements);
        }

        public void Dispose()
        {
            _cancellationTokenSource.Dispose();
        }

        private async Task ProcessAdvertisements()
        {
            var availableAdvertisements = await _advertisementRepository.Read();

            while (!_cancellationTokenSource.Token.IsCancellationRequested)
            {
                var location = locationProvider.GetLocation();
                var weather = await weatherApi.GetWeatherFor(location);
                var vrijeme = _clock.Now();

                Console.WriteLine($"\nslat:{location.Latitude}|long:{location.Longitude}| time:{vrijeme}| temp:{weather.Temperature}");

                var context = new Context(vrijeme, location, weather);

                var advertisementsToShow = availableAdvertisements
                    .Where(advertisement => advertisement.ShouldShowAd(context))
                    .ToList();

                ActiveAdvertisements?.Invoke(this, advertisementsToShow);

                await Task.Delay(1000, _cancellationTokenSource.Token);
            }
        }
    }
}
