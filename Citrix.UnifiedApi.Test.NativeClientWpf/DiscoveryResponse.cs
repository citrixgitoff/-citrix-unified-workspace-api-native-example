﻿/*
* Copyright © 2023. Cloud Software Group, Inc.
* This file is subject to the license terms contained
* in the license file that is distributed with this file.
*/

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Citrix.UnifiedApi.Test.NativeClientWpf
{
    public class DiscoveryResponse
    {
        [JsonPropertyName("services")]
        public List<Service> Services { get; set; }
    }
}
