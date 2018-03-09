using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Iteragram.Api;
using Iteragram.Api.Models;
using Iteragram.Models;
using Iteragram.Models.Responses;

namespace Iteragram.Services
{
    public interface IUserApiClient : IApiClient
    {
        Task<BaseApiResult<UsersResponse>> GetClient();
    }
}
