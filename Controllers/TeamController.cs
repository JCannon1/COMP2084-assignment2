using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    // Allowing only Administrators to have access 
    [Authorize(Roles = "Administrator")]
    public class TeamController : Controller
    {
        // db connection 
        HockeyModel db = new HockeyModel();

        // GET: Team
        public ActionResult Index()
        {
            var Table_HockeyTeams = db.Table_HockeyTeams.ToList();

            return View(Table_HockeyTeams);
        }

        // Team Browse
        public ActionResult Browse(string genre)
        {
            var t = db.Table_HockeyTeams.Include("Teams")
                .SingleOrDefault(th => th.Name == Table_HockeyTeams);

            return View(t);
        }
    }
}