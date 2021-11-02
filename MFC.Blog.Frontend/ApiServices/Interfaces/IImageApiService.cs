using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFC.Blog.Frontend.ApiServices.Interfaces
{
    public interface IImageApiService
    {
        Task<string> GetBlogImageByIdAsync(int id);
    }
}
