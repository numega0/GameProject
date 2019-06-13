using System.Web.Mvc;
using GameProject.Entity.Concrete;
using GameProject.Interfaces;


namespace GameProject.MvcUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Route("Category/{categoryId}")]
        public ActionResult Index(int categoryId = 0)
        {
            Category category = _categoryService.GetCategoryById(categoryId);

            return View(category);
        }


        //
    }
}