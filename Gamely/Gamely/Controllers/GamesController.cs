using Gamely.Models;
using Gamely.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace Gamely.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageGames)]
        public ActionResult New()
        {
            var gameGenres = _context.GameGenres.ToList();
            var viewModel = new GameFormViewModel
            {
                Game = new Game(),
                GameGenres = gameGenres,
                Title = "Новая игра"
            };
            return View("GameForm", viewModel);
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageGames)]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Game game)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new GameFormViewModel
                {
                    Game = game,
                    GameGenres = _context.GameGenres.ToList()
                };
                return View("GameForm", viewModel);
            }

            if (game.Id == 0)
            {
                game.DateAdded = DateTime.Now;
                _context.Games.Add(game);
            }
            else
            {
                var gameInDb = _context.Games.Single(g => g.Id == game.Id);

                gameInDb.Name = game.Name;
                gameInDb.GameGenreId = game.GameGenreId;
                gameInDb.ReleaseDate = game.ReleaseDate;
                gameInDb.NumberInStock = game.NumberInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }

        public ActionResult Index()
        {
            var games = _context.Games.Include(g => g.GameGenre).ToList();

            if (User.IsInRole(RoleName.CanManageGames))
                return View("List", games);
            
            return View("ReadOnlyList", games);
        }

        public ActionResult Details(int id = 1)
        {
            var game = _context.Games.Include(g => g.GameGenre).SingleOrDefault(g => g.Id == id);

            if (game == null) return HttpNotFound();

            return View(game);
        }

        [Authorize(Roles = RoleName.CanManageGames)]
        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null) HttpNotFound();

            var viewModel = new GameFormViewModel
            {
                Game = game,
                Title = "Редакировать игру",
                GameGenres = _context.GameGenres.ToList()
            };

            return View("GameForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageGames)]
        public ActionResult Delete(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null) return HttpNotFound();

            return View(game);
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageGames)]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null)
            {
                return HttpNotFound();
            }

            _context.Games.Remove(game);
            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }
    }
}