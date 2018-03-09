using System;
namespace Iteragram.Models.Responses
{
    public abstract class Response
    {
        public Meta Meta { get; set; }
        public int RateLimitLimit { get; set; }
        public int RateLimitRemaining { get; set; }
    }
}
