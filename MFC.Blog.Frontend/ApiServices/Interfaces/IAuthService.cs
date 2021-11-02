using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFC.Blog.Frontend.Models;

namespace MFC.Blog.Frontend.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
        Task<bool> SignIn(AppUserLoginModel model);
    }
}
