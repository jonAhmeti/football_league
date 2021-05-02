using System.Web.Mvc;
using FootballLeague.Models;
using WebGrease;

namespace FootballLeague.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            model = Models.Login.CheckForUser(model);
            if (model.Username == model.Username)
            {
                if (model.RoleId == 1)
                {
                    return RedirectToRoute("Admin", model);
                }
                else if (model.RoleId == 2)
                {
                    return RedirectToRoute("User", model);
                }
            }

            return RedirectToAction("Register");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Login model)
        {
            Models.Login.AddUser(model);
            return RedirectToAction("Index");
        }
    }
}