using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDemo.Models;

namespace MyDemo.Controllers
{
    public class VideoGamesController : Controller
    {
        [Route("VideoGames/rating/{rating:regex(\\w{1})")] //replacing the route commented out in routeconfig

        // GET: /VideoGames/Game
        public ActionResult Game()
        {
            var Game = new VideoGame();

            Game.Id = 1;
            Game.Name = "Doom";
            Game.Rating = 'M';
            Game.Genre = "FPS";

            return View(Game);
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

        public ActionResult ByRating(char rating)
        {
            return Content("ESRB Rating: " + rating);
        }
    }
}