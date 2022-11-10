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
            s.SessionId = 1;
            s.DM = "Katie";
            s.Gold = 10;
            s.Exp = 20;

            CharacterModel c = new();
            c.CharId = 1;
            c.UserId = 1;
            c.Name = "Eranir";
            c.ConcurrencyId = 1;

            SessionItemModel sim = new();
            sim.SessionId = 1;
            sim.Name = "Test data";
            sim.Value = 1;
            sim.Type = SessionItemModel.ItemType.Monster;

            SessionItemModel sim2 = new();
            sim2.SessionId = 1;
            sim2.Name = "Test data";
            sim2.Value = 1;
            sim2.Type = SessionItemModel.ItemType.Adhoc;

            SessionItemModel sim3 = new();
            sim3.SessionId = 1;
            sim3.Name = "Test data";
            sim3.Value = 1;
            sim3.Type = SessionItemModel.ItemType.Item;

            s.Characters.Add(c);
            s.Monsters.Add(sim);
            s.AdHocs.Add(sim2);
            s.Items.Add(sim3);

            return View(s);
        }
    }
}
