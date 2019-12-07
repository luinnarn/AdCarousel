using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AdProvider.Model;
using AdProvider.Repository;

namespace AdProvider
{
    public class AdProviderFacade : IDisposable
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        private readonly IAdvertisementRepository _advertisementRepository = new AdvertisementRepositoryMock();

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
                var advertisementsToShow = availableAdvertisements
                    .Where(advertisement => advertisement.Rule is TimeOfDayRule rule
                                            && rule.StartTime < DateTime.Now.TimeOfDay
                                            && DateTime.Now.TimeOfDay < rule.StartTime + rule.Duration)
                    .ToList();

                ActiveAdvertisements?.Invoke(this, advertisementsToShow);

                await Task.Delay(1000, _cancellationTokenSource.Token);
            }
        }
    }
}
