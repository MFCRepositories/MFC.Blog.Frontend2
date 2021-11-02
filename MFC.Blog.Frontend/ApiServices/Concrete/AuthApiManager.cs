using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MFC.Blog.Frontend.ApiServices.Interfaces;
using MFC.Blog.Frontend.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MFC.Blog.Frontend.ApiServices.Concrete
{
    public class AuthApiManager : IAuthApiService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly HttpClient _httpClient;

        public AuthApiManager(IHttpContextAccessor httpContextAccessor, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
            _httpClient.BaseAddress = new Uri("http://localhost:53107/api/Auth/");
        }
        public async Task<bool> SignIn(AppUserLoginModel model)
        {
            var jsonData = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync("SignIn", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                var accessToken = JsonConvert.DeserializeObject<AccessToken>(await responseMessage.Content.ReadAsStringAsync());

                _httpContextAccessor.HttpContext.Session.SetString("token", accessToken.Token);

                return true;
            }
            return false;
        }
    }
}
