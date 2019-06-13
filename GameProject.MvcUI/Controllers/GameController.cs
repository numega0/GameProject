using GameProject.Entity.Concrete;
using GameProject.Interfaces;
using GameProject.MvcUI.Models;
using System.Web.Mvc;

namespace GameProject.MvcUI.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        private readonly ICategoryService _categoryService;

        public GameController(IGameService gameService, ICategoryService categoryService)
        {
            _gameService = gameService;
            _categoryService = categoryService;
        }

        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "A")]
        [Route("Game/Edit/{gameId}")]
        public ActionResult Edit(int gameId)
        {
            return View("GameForm", new GameViewModel
            {
                Game = _gameService.GetGameById(gameId),
                Categories = _categoryService.GetAll()
            });
        }

        [HttpGet]
        [Authorize(Roles = "A")]
        [Route("Game/New")]
        public ActionResult New()
        {
            return View("GameForm", new GameViewModel
            {
                Categories = _categoryService.GetAll()
            });
        }


        [ValidateAntiForgeryToken]
        [Route("Student/Save")]
        public ActionResult Save(Game game)
        {
            if (game.Id == 0)	// id 0 gelirse yeni kayıttır ekleme yapar
            {
                _gameService.Add(game);
            }
            else
            {
                _gameService.Update(game); // id varolan bir id ise update yapar
            }

            return RedirectToAction("Index", "Category");
        }


    }
}