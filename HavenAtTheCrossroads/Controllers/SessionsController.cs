using HavenAtTheCrossroads.Models;
using Microsoft.AspNetCore.Mvc;

namespace HavenAtTheCrossroads.Controllers
{
    public class SessionsController : Controller
    {
        public IActionResult Index()
        {
            List<SessionModel> s = new();
            return View(s);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            SessionModel s = new();
            return View(s);
        }
    }
}
