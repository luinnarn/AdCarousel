﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AdProvider.Model;

namespace AdProvider.Repository
{
    internal interface IAdvertisementRepository
    {
        Task<IEnumerable<Advertisement>> Read();
    }
}
