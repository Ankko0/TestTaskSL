using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softline.Models;
using System;
using System.Linq;

namespace Softline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        UserContext _db;

        public HomeController(ILogger<HomeController> logger, UserContext context) //IoC
        {
            _logger = logger;
            _db = context;
        }

        public IActionResult Index()
        {
            return View(_db.Users.ToList());
        }

        [HttpPost]
        public IActionResult Insert(User user)
        {
            if (user != null)
            {
                try
                {
                    _db.Users.Add(user);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Insert error");
                }

            }
            return RedirectToAction("Index");
        }
    }
}
