using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFC.Blog.Frontend.ApiServices.Interfaces;
using MFC.Blog.Frontend.Models;

namespace MFC.Blog.Frontend.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthApiService _authApiService;
        public AccountController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> SignIn(AppUserLoginModel model)
        {
            if (await _authApiService.SignIn(model))
            {
                return RedirectToAction("Index", "Blog", new { @area = "Admin" });
            }

            return View();
        }

    }
}
