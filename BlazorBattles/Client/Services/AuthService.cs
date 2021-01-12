using BlazorBattles.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Auth/login", request);
            return await response.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Auth/register", request);
            return await response.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
