using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFC.Blog.Frontend.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MFC.Blog.Frontend.ViewComponents
{
    public class CategoryList : ViewComponent
    {
        private readonly ICategoryApiService _categoryApiService;
        public CategoryList(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_categoryApiService.GetAllWithBlogsCount().Result);
        }
    }
}
