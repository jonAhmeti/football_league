using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballLeague.Models;

namespace FootballLeague.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            return View(Team.GetAll());
        }

        // GET: Team/Details/5
        public ActionResult Details(Team model)
        {
            return View(Team.GetTeam(model));
        }

        // GET: Team/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Team/Create
        [HttpPost]
        public ActionResult Create(Team model)
        {
                Team.Add(model);
                return RedirectToAction("Index");
        }

        // GET: Team/Edit/5
        public ActionResult Edit(int id)
        {
            Team model = new Team() {Id = id};
            return View(Team.GetTeam(model));
        }

        // POST: Team/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Team model)
        {
            try
            {
                Team.Edit(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Team/Delete/5
        public ActionResult Delete(int id)
        {
            Team model = new Team() {Id = id};
            return View(Team.GetTeam(model));
        }

        // POST: Team/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Team model)
        {
            try
            {
                Team.Delete(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
