using System.Web.Mvc;
using FootballLeague.Models;

namespace FootballLeague.Controllers.UserControllers
{
    public class UserLeagueController : Controller
    {
        // GET: UserLeague
        public ActionResult Index()
        {
            return View(League.GetAll());
        }

        // GET: League/Details/5
        public ActionResult Details(League model)
        {
            return View(League.GetLeague(model));
        }
    }
}