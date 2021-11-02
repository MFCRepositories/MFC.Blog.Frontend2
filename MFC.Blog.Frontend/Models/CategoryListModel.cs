using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFC.Blog.Frontend.Models
{
    public class CategoryListModel : IEquatable<CategoryListModel>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals([AllowNull] CategoryListModel other)
        {
            return this.Id == other.Id && this.Name == other.Name;
        }
    }
}
