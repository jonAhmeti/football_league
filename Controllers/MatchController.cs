using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballLeague.Models;

namespace FootballLeague.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        public ActionResult Index()
        {
            return View(Match.GetAll());
        }

        // GET: Match/Details/5
        public ActionResult Details(Match model)
        {
            return View(Match.GetMatch(model));
        }

        // GET: Match/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Match/Create
        [HttpPost]
        public ActionResult Create(Match model)
        {
                Match.Add(model);
                return RedirectToAction("Index");
        }

        // GET: Match/Edit/5
        public ActionResult Edit(int id)
        {
            Match model = new Match(){Id = id};
            return View(Match.GetMatch(model));
        }

        // POST: Match/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Match model)
        {
            try
            {
                Match.Edit(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Match/Delete/5
        public ActionResult Delete(int id)
        {
            Match model = new Match() {Id = id};
            return View(Match.GetMatch(model));
        }

        // POST: Match/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Match model)
        {
            try
            {
                Match.Delete(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
