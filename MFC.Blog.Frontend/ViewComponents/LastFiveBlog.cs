using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFC.Blog.Frontend.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MFC.Blog.Frontend.ViewComponents
{
    public class LastFiveBlog : ViewComponent
    {
        private readonly IBlogApiService _blogApiService;
        public LastFiveBlog(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }
        public IViewComponentResult Invoke()
        {

            return View(_blogApiService.GetLastFiveAsync().Result);
        }
    }
}
