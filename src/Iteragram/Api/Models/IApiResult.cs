using System;
namespace Iteragram.Api.Models
{
    public interface IApiResult<T> : IApiMinify
    {
        bool Success { get; set; }
        T Data { get; set; }
        string Message { get; set; }
        string Id { get; set; }
        object ModelState { get; set; }
        string Url { get; set; }
    }
}
