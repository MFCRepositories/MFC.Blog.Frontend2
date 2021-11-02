using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFC.Blog.Frontend.Models;

namespace MFC.Blog.Frontend.ApiServices.Interfaces
{
    public interface ICategoryApiService
    {
        Task<List<CategoryListModel>> GetAllAsync();
        Task<List<CategoryWithBlogsCountModel>> GetAllWithBlogsCount();

        Task<CategoryListModel> GetByIdAsync(int id);

        Task AddAsync(CategoryAddModel model);

        Task UpdateAsync(CategoryUpdateModel model);
        Task DeleteAsync(int id);
    }
}
