using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MFC.Blog.Frontend.ApiServices.Interfaces;

namespace MFC.Blog.Frontend.ApiServices.Concrete
{
    public class ImageApiManager : IImageApiService
    {
        private readonly HttpClient _httpClient;
        public ImageApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:53107/api/images/");
        }

        public async Task<string> GetBlogImageByIdAsync(int id)
        {
            //GetBlogImageById

            var responseMessage = await _httpClient.GetAsync($"GetBlogImageById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var bytes = await responseMessage.Content.ReadAsByteArrayAsync();
                return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
            }
            return null;
        }


    }
}
