using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers
{

    // Allowing only those with accounts to have access 
    //[Authorize]
    public class TeamController : Controller
    {
        // db connection 
        HockeyModel db = new HockeyModel(); 

        // GET: Team
        public ActionResult Index()
        {
            var teams = db.Table_HockeyTeams.ToList();

            return View(teams);
        }

        // Team Browse
        public ActionResult Browse(string team)
        {
            var t = db.Table_HockeyTeams.Include("Table_HockeyPlayers")
                .SingleOrDefault(th => th.teamName == team);

            return View(t);
        }
    }
}