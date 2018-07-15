using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDemo.Models;
using MyDemo.ViewModels;

namespace MyDemo.Controllers
{
    public class VideoGamesController : Controller
    {
        //[Route("VideoGames/rating/{rating:regex(\\w{1})}")] //replacing the route commented out in routeconfig

        // GET: /VideoGames/Game
        public ActionResult Game()
        {
            var game = new VideoGame();

            var viewModel = new VideoGamesViewModel
            {
                Game = game
            };

            game.Id = 1;
            game.Name = "Doom";
            game.Rating = 'M';
            game.Genre = "FPS";

            return View(viewModel);
        }

        // /VideoGames
        public ActionResult Index(int? pageIndex, string sortBy) //pageIndex is a nullable value
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content("Page Index = " + pageIndex);
        }

        public ActionResult ByRating(char? rating)
        {

            return Content("ESRB Rating: " + rating);
        }
    }
}