using GameProject.Entity.Concrete;
using GameProject.Interfaces;
using System.Web.Mvc;
using System.Web.Security;


namespace GameProject.MvcUI.Controllers
{
    public class SecurityController : Controller
    {
        private readonly IUserService _userService;

        public SecurityController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Security
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return RedirectToAction("Index", "Security");
        }



        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(User user)
        {
            FormsAuthentication.SetAuthCookie(user.UserName, false);
            return _userService.Auth(user) ?
                RedirectToAction("Index", "Home") :
                RedirectToAction("Index", "Security");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        //[FluentValidationAspect(typeof(UserValidator))]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (_userService.Check(user) == false)
                _userService.Add(user);

            return RedirectToAction("Index", "Security");
        }




        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Security");
        }
    }
}