using GameProject.Entity.Concrete;
using GameProject.Interfaces;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GameProject.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult GetNavbar()
        {
            List<Category> categories = _categoryService.GetAll();

            return PartialView("_Navbar", categories);
        }
    }
}