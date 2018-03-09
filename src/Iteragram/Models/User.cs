using System;
using System.Collections.Generic;

namespace Iteragram.Models
{
    public class User
    {
        public UserInfo user { get; set; }
        public Image images { get; set; } 
        public string Bio { get; set; }
        public string Website { get; set; }
    }
}
