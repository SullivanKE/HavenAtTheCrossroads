using HavenAtTheCrossroads.Models;
using Microsoft.AspNetCore.Mvc;
using HavenAtTheCrossroads;
using System.Collections.Generic;

namespace HavenAtTheCrossroads.Controllers
{
    public class SessionsController : Controller
    {
        public IActionResult Index()
        {
            List<SessionModel> s = new List<SessionModel>();
            return View(s);
        }

        public IActionResult Add()
        {
            SessionModel s = new SessionModel();

            return View(s);
        }
        public IActionResult AddChar(SessionModel s)
        {
            s.Characters.Add(new CharacterModel());
            return View("Add", s);
        }
        [Route("DelChar/{index}")]
        public IActionResult DelChar(int index, SessionModel s)
        {

            s.Characters.RemoveAt(index);
            ModelState.Clear();
            return View("Add", s);
        }
        public IActionResult AddAdhoc(SessionModel s)
        {
            s.AdHocs.Add(new SessionItemModel());
            return View("Add", s);
        }

        [Route("DelAdhoc/{index}")]
        public IActionResult DelAdhoc(int index, SessionModel s)
        {
            
            s.AdHocs.RemoveAt(index);
            ModelState.Clear();
            return View("Add", s);
        }
        public IActionResult AddMonster(SessionModel s)
        {
            s.Monsters.Add(new MonsterModel());
            return View("Add", s);
        }

        [Route("DelMonster/{index}")]
        public IActionResult DelMonster(int index, SessionModel s)
        {
            s.Monsters.RemoveAt(index);
            ModelState.Clear();
            return View("Add", s);
        }

        public IActionResult Edit()
        {
            SessionModel s = new SessionModel();
            

            return View(s);
        }
    }
}
