using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class HockeyTeamsController : Controller
    {
        private HockeyModel db = new HockeyModel();

        // GET: HockeyTeams
        public ActionResult Index()
        {
            return View(db.Table_HockeyTeams.ToList());
        }

        // GET: HockeyTeams/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_HockeyTeams table_HockeyTeams = db.Table_HockeyTeams.Find(id);
            if (table_HockeyTeams == null)
            {
                return HttpNotFound();
            }
            return View(table_HockeyTeams);
        }

        // GET: HockeyTeams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HockeyTeams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "teamId,teamCity,teamName,teamStanding")] Table_HockeyTeams table_HockeyTeams)
        {
            if (ModelState.IsValid)
            {
                db.Table_HockeyTeams.Add(table_HockeyTeams);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_HockeyTeams);
        }

        // GET: HockeyTeams/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_HockeyTeams table_HockeyTeams = db.Table_HockeyTeams.Find(id);
            if (table_HockeyTeams == null)
            {
                return HttpNotFound();
            }
            return View(table_HockeyTeams);
        }

        // POST: HockeyTeams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "teamId,teamCity,teamName,teamStanding")] Table_HockeyTeams table_HockeyTeams)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_HockeyTeams).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_HockeyTeams);
        }

        // GET: HockeyTeams/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_HockeyTeams table_HockeyTeams = db.Table_HockeyTeams.Find(id);
            if (table_HockeyTeams == null)
            {
                return HttpNotFound();
            }
            return View(table_HockeyTeams);
        }

        // POST: HockeyTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Table_HockeyTeams table_HockeyTeams = db.Table_HockeyTeams.Find(id);
            db.Table_HockeyTeams.Remove(table_HockeyTeams);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
