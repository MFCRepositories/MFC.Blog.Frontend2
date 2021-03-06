using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFC.Blog.Frontend.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MFC.Blog.Frontend.ViewComponents
{
    public class GetCategoryName : ViewComponent
    {
        private readonly ICategoryApiService _categoryApiService;
        public GetCategoryName(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }
        public IViewComponentResult Invoke(int categoryId)
        {

            return View(_categoryApiService.GetByIdAsync(categoryId).Result);
        }
    }
}
