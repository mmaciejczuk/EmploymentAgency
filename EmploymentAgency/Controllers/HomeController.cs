using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmploymentAgency.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _repo;

        public HomeController(IUserService repo)
        {
            _repo = repo;
        }

        // GET: Home
        public ActionResult Index()
        {
            var users = _repo.GetUsers().AsQueryable();
            return View(users);
        }
    }
}