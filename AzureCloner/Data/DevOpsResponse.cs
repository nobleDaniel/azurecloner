﻿using Newtonsoft.Json;

namespace AzureCloner.Data
{
    public class DevOpsResponse
    {
        [JsonProperty("value")] public DevOpsRepo[] DevOpsRepos { get; set; }
        public int Count { get; set; }
    }
}
