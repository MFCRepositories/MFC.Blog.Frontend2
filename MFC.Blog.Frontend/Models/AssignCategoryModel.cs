using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFC.Blog.Frontend.Models
{
    public class AssignCategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Exists { get; set; }
    }
}
