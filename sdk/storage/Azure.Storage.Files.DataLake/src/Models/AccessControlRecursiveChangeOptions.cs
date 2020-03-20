﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary>
    /// AccessControlRecursiveChangeOptions contain knobs used to customize recursive Access Control operations.
    /// </summary>
    public struct AccessControlRecursiveChangeOptions
    {
        /// <summary>
        /// Optional. If data set size exceeds batch size then operation will be split into multiple requests so that progress can be tracked.
        /// Batch size should be between 1 and 2000. Default is 2000.
        /// </summary>
        public int? BatchSize { get; set; }
    }
}
