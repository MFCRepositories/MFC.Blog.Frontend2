using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFC.Blog.Frontend.Models
{
    public class CategoryAddModel
    {
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        [Display(Name = "Ad :")]
        public string Name { get; set; }
    }
}
