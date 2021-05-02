using System.Web.Mvc;
using FootballLeague.Models;

namespace FootballLeague.Controllers.UserControllers
{
    public class UserMatchController : Controller
    {
        // GET: Match
        public ActionResult Index()
        {
            return View(Match.GetAll());
        }

        [HttpPost]
        public ActionResult Index(string dropSort)
        {
            if (dropSort == "goals")
            {
                return View(Match.GetAllByGoal());
            }
            if (dropSort == "stadium")
            {
                return View(Match.GetAllByStadium());
            }
            if (dropSort == "home")
            {
                return View(Match.GetAllByHome());
            }
            if (dropSort == "away")
            {
                return View(Match.GetAllByAway());
            }

            return View(Match.GetAll());
        }

        // GET: Match/Details/5
        public ActionResult Details(Match model)
        {
            return View(Match.GetMatch(model));
        }
    }
}