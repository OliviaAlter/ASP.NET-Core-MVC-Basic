using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_MVC_Basic.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int DisplayOrder { get; set; }

    }
}
