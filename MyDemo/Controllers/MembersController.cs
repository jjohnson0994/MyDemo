using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDemo.Models;
using MyDemo.ViewModels;

namespace MyDemo.Controllers
{
    public class MembersController : Controller
    {

        [Route("Members/Index/")]
        // GET: Members
        public ActionResult Index()
        {
            var members = new List<Member>
            {
                new Member { Name = "Jim", Age = 23, Id= 1},
                new Member { Name = "Hallie", Age = 21, Id = 2},
                new Member { Name = "Koopa", Age = 6, Id = 3}
            };

            var viewModel = new MembersViewModel
            {
                Members = members
            };
            return View(viewModel);
        }
    }
}