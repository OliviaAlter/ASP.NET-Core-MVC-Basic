using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC_Basic.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1, int.MaxValue, 
            ErrorMessage = "Display order for category must be larger than 0")]
        public int DisplayOrder { get; set; }

    }
}
