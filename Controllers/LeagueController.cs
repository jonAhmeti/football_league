using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballLeague.Models;

namespace FootballLeague.Controllers
{
    public class LeagueController : Controller
    {
        // GET: League
        public ActionResult Index()
        {
            return View(League.GetAll());
        }

        // GET: League/Details/5
        public ActionResult Details(League model)
        {
            return View(League.GetLeague(model));
        }

        // GET: League/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: League/Create
        [HttpPost]
        public ActionResult Create(League model)
        {
            League.Add(model);
            return RedirectToAction("Index");

        }

        // GET: League/Edit/5
        public ActionResult Edit(int id)
        {
            League league = new League() {Id = id};
            return View(League.GetLeague(league));
        }

        // POST: League/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, League model)
        {
            try
            {
                League.Edit(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: League/Delete/5
        public ActionResult Delete(int id)
        {
            League model = new League() {Id = id};
            return View(League.GetLeague(model));
        }

        // POST: League/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, League model)
        {
            try
            {
                League.Delete(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
