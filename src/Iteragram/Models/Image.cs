using System;
using Newtonsoft.Json;

namespace Iteragram.Models
{
    public class Image
    {

        [JsonProperty("low_resolution")]
        public Resolution LowResolution { get; set; }

        public Resolution Thumbnail { get; set; }

        [JsonProperty("standard_resolution")]
        public Resolution StandardResolution { get; set; }
    }
}
