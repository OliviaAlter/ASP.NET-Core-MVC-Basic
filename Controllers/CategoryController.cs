using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_MVC_Basic.Database;
using ASP.NET_Core_MVC_Basic.Models;

namespace ASP.NET_Core_MVC_Basic.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDdContext _applicationDdContext;

        public CategoryController(ApplicationDdContext applicationDdContext)
        {
            _applicationDdContext = applicationDdContext;
        }

        public IActionResult Category()
        {
            IEnumerable<CategoryModel> category = _applicationDdContext.Category;
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
