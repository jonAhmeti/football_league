using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FootballLeague.Models;
using Microsoft.Ajax.Utilities;

namespace FootballLeague.Controllers.UserControllers
{
    public class UserPlayerController : Controller
    {
        // GET: Match
        public ActionResult Index()
        {
            return View(Player.GetAll());

        }

        [HttpPost]
        public ActionResult Index(string dropSort)
        {
            if (dropSort == "age")
            {
                return View(Player.GetAllByAge());
            }
            if (dropSort == "club")
            {
                return View(Player.GetAllByClub());
            }
            if (dropSort == "nationality")
            {
                return View(Player.GetAllByNationality());
            }
            if (dropSort == "goals")
            {
                return View(Player.GetAllByGoals());
            }

            return View(Player.GetAll());
        }

        [HttpPost]
        public ActionResult SearchPlayer(string dropSearch,string inputSearch)
        {
            return View(Player.SearchBy(dropSearch,inputSearch).Count >= 1 ?
                Player.SearchBy(dropSearch, inputSearch) : new List<Player>
                {
                    new Player(){FullName = "There is no player with the given parameter."}
                });
        }

        // GET: Match/Details/5
        public ActionResult Details(Player model)
        {
            return View(Player.GetPlayer(model));
        }
    }
}