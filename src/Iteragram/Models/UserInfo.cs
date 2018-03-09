using System;
using Newtonsoft.Json;

namespace Iteragram.Models
{
    public class UserInfo
    {
        public long Id { get; set; }

        public string Username { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }
    }
}
