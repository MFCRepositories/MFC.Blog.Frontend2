using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFC.Blog.Frontend.Models
{
    public class CategoryUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        [Display(Name = "Ad :")]
        public string Name { get; set; }
    }
}
