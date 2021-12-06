using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200Team3.DAL;
using MIS4200Team3.Models;

namespace MIS4200Team3.Controllers
{
    public class RecognizePeoplesController : Controller
    {
        private RegisterContext db = new RegisterContext();

        // GET: RecognizePeoples
        public ActionResult Index()
        {
            return View(db.RecognizePeoples.ToList());
        }

        // GET: RecognizePeoples/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecognizePeople recognizePeople = db.RecognizePeoples.Find(id);
            if (recognizePeople == null)
            {
                return HttpNotFound();
            }
            return View(recognizePeople);
        }

        // GET: RecognizePeoples/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecognizePeoples/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecognizePeopleID,recognizerFirstName,recognizerLastName,recognizeeFirstName,recognizeeLastName,Values")] RecognizePeople recognizePeople)
        {
            if (ModelState.IsValid)
            {
                db.RecognizePeoples.Add(recognizePeople);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recognizePeople);
        }

        // GET: RecognizePeoples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecognizePeople recognizePeople = db.RecognizePeoples.Find(id);
            if (recognizePeople == null)
            {
                return HttpNotFound();
            }
            return View(recognizePeople);
        }

        // POST: RecognizePeoples/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecognizePeopleID,recognizerFirstName,recognizerLastName,recognizeeFirstName,recognizeeLastName,Values")] RecognizePeople recognizePeople)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recognizePeople).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recognizePeople);
        }

        // GET: RecognizePeoples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecognizePeople recognizePeople = db.RecognizePeoples.Find(id);
            if (recognizePeople == null)
            {
                return HttpNotFound();
            }
            return View(recognizePeople);
        }

        // POST: RecognizePeoples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RecognizePeople recognizePeople = db.RecognizePeoples.Find(id);
            db.RecognizePeoples.Remove(recognizePeople);
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
