﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.ChangeFeed.Pagination
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Cosmos.Json;
    using Microsoft.Azure.Cosmos.Query.Core.Monads;
    using Microsoft.Azure.Cosmos.Tracing;

    internal interface IMonadicChangeFeedDataSource
    {
        Task<TryCatch<ChangeFeedPage>> MonadicChangeFeedAsync(
            ChangeFeedState state,
            FeedRangeInternal feedRange,
            ChangeFeedRequestOptions changeFeedRequestOptions,
            ChangeFeedMode changeFeedMode,
            ITrace trace,
            CancellationToken cancellationToken);
    }
}
