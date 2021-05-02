using System.Web.Mvc;
using FootballLeague.Models;

namespace FootballLeague.Controllers.UserControllers
{
    public class UserTeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            return View(Team.GetAll());
        }

        [HttpPost]
        public ActionResult Index(string dropSort)
        {
            if (dropSort == "cards")
            {
                return View(Team.GetAllByCards());
            }
            if (dropSort == "country")
            {
                return View(Team.GetAllByCountry());
            }
            if (dropSort == "fouls")
            {
                return View(Team.GetAllByFouls());
            }
            if (dropSort == "goals")
            {
                return View(Team.GetAllByGoals());
            }
            if (dropSort == "leaguePos")
            {
                return View(Team.GetAllByLeaguePos());
            }
            if (dropSort == "losses")
            {
                return View(Team.GetAllByLosses());
            }
            if (dropSort == "wins")
            {
                return View(Team.GetAllByWins());
            }
            return View(Team.GetAll());
        }

        // GET: Team/Details/5
        public ActionResult Details(Team model)
        {
            return View(Team.GetTeam(model));
        }
    }
}