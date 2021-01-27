using System.Collections.Generic;
using ASP.NET_Core_MVC_Basic.Database;
using ASP.NET_Core_MVC_Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_MVC_Basic.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDdContext _applicationDdContext;

        public ApplicationTypeController(ApplicationDdContext applicationDdContext)
        {
            _applicationDdContext = applicationDdContext;
        }

        public IActionResult ApplicationType()
        {
            IEnumerable<ApplicationType> type = _applicationDdContext.ApplicationType;
            return View(type);
        }

        //GET - CREATE
        public IActionResult CreateApplicationType()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateApplicationType(ApplicationType obj)
        {
            _applicationDdContext.ApplicationType.Add(obj);
            _applicationDdContext.SaveChanges();
            return RedirectToAction("ApplicationType");
        }
    }
}