using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MFC.Blog.Frontend.ViewComponents
{
    public class Search : ViewComponent
    {
        public IViewComponentResult Invoke(string s)
        {
            ViewBag.SearchString = s;
            return View();
        }
    }
}
