using HavenAtTheCrossroads.Models;
using Microsoft.AspNetCore.Mvc;

namespace HavenAtTheCrossroads.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index()
        {
            List<CharacterModel> c = new();
            return View(c);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            CharacterModel c = new();
            return View(c);
        }
    }
}
