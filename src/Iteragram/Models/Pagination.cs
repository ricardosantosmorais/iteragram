using System;
using Newtonsoft.Json;

namespace Iteragram.Models
{
    public class Pagination
    {
        [JsonProperty("next_url")]
        public string NextUrl { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        [JsonProperty("next_max_id")]
        [Obsolete]
        public string NextMaxId { get; set; }

        [JsonProperty("next_min_id")]
        [Obsolete]
        public string NextMinId { get; set; }

        [JsonProperty("min_tag_id")]
        public string MinTagId { get; set; }

        [JsonProperty("next_max_tag_id")]
        public string NextMaxTagId { get; set; }
    }
}
