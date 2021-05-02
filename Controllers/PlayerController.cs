using System;
using System.Web.Mvc;
using FootballLeague.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FootballLeague.Controllers
{
    public class PlayerController : Controller
    {
        // GET: AllPlayers
        public ActionResult Index()
        {
            return View(Player.GetAll());
        }


        // GET: PlayerDetails
        public ActionResult Details(Player model)
        {
            return View(Player.GetPlayer(model));
        }

        //GET: PlayerCreate
        public ActionResult Create()
        {
            return View();
        }

        //POST: PlayerCreate
        [HttpPost]
        public ActionResult Create(Player model)
        {
            Player.Add(model);
            return RedirectToAction("Index");
        }

        //GET: PlayerDelete
        public ActionResult Delete(int id)
        {
            Player model = new Player()
            {
                Id = id
            };

            return View(Player.GetPlayer(model));
        }

        //POST: PlayerDelete
        [HttpPost]
        public ActionResult Delete(Player model)
        {
            Player.Delete(model);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Player model = new Player() {Id = id};
            return View(Player.GetPlayer(model));
        }
        //POST: PlayerEdit
        [HttpPost]
        public ActionResult Edit(Player model)
        {
            Player.Edit(model);
            return RedirectToAction("Index");
        }


    }
}