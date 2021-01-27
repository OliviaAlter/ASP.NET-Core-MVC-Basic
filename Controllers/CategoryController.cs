using System.Collections.Generic;
using ASP.NET_Core_MVC_Basic.Database;
using ASP.NET_Core_MVC_Basic.Models;
using Microsoft.AspNetCore.Mvc;

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

        //GET - DELETE
        public IActionResult DeleteCategory(int? id)
        {
            /*
            if (string.IsNullOrEmpty(id.ToString()))
                return NotFound();
            var obj = _applicationDdContext.Category.Find(id);
            if (obj == null)
                return NotFound();
            return View(obj);
            */
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _applicationDdContext.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCategoryPost(int? id)
        {
            /*
            var obj = _applicationDdContext.Category.Find(id);
            if (obj == null)
                return NotFound();
            _applicationDdContext.Category.Remove(obj);
            _applicationDdContext.SaveChanges();
            return RedirectToAction("Category");
            */
            var obj = _applicationDdContext.Category.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _applicationDdContext.Category.Remove(obj);
            _applicationDdContext.SaveChanges();
            return RedirectToAction("Category");

        }


        //GET - EDIT
        public IActionResult EditCategory(int? id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
                return NotFound();
            var obj = _applicationDdContext.Category.Find(id);
            if (obj == null)
                return NotFound();
            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCategory(CategoryModel obj)
        {
            if (!ModelState.IsValid) return View(obj);
            _applicationDdContext.Category.Update(obj);
            _applicationDdContext.SaveChanges();
            return RedirectToAction("Category");
        }

        //GET - CREATE
        public IActionResult CreateCategory()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCategory(CategoryModel obj)
        {
            if (!ModelState.IsValid) return View(obj);
            _applicationDdContext.Category.Add(obj);
            _applicationDdContext.SaveChanges();
            return RedirectToAction("Category");
        }
    }
}