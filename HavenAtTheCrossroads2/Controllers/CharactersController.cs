using HavenAtTheCrossroads.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HavenAtTheCrossroads.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index()
        {
            List<CharacterModel> c = new List<CharacterModel>();
            return View(c);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            CharacterModel c = new CharacterModel();
            return View(c);
        }
    }
}
