using System;
using System.Threading.Tasks;
using Iteragram.Api;
using Iteragram.Api.Models;
using Iteragram.Models;
using Iteragram.Models.Responses;

namespace Iteragram.Services
{
    public sealed class UserApiClient : ApiClient, IUserApiClient
    {

        public UserApiClient()
            : base("https://api.instagram.com/v1/users/46966167/media/recent/?access_token=46966167.5a23238.63f216382a8544fdacfb53c8a566d1ce")
        {
            
        }

        public async Task<BaseApiResult<UsersResponse>> GetClient()
        {
            return await GetAsync<UsersResponse>("");
        }
    }
}
