﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agathas.Storefront.Infrastructure.Configuration
{
    public interface IApplicationSettings
    {
        string LoggerName { get; }
        string NumberOfResultsPerPage { get; }
        string JanrainApiKey { get;  }

        string PayPalBusinessEmail { get; }
        string PayPalPaymentPostToUrl { get; }

    }
}
