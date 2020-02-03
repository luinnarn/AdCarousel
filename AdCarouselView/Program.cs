using System;
using System.Collections.Generic;
using AdProvider;
using AdProvider.Model;

namespace AdCarouselView
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using var adProvider = new AdProviderFacade();
            adProvider.ActiveAdvertisements += ActiveAdvertisements;
            Console.ReadLine();
            adProvider.ActiveAdvertisements -= ActiveAdvertisements;
        }

        private static void ActiveAdvertisements(object sender, IEnumerable<Advertisement> advertisements)
        {
            Console.WriteLine($"Showing {string.Join(", ", advertisements)}");
        }
    }
}
