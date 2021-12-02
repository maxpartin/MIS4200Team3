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
    public class RegisterSecondariesController : Controller
    {
        private RegisterContext db = new RegisterContext();

        // GET: RegisterSecondaries
        public ActionResult Index()
        {
            return View(db.RegisterSecondary.ToList());
        }

        // GET: RegisterSecondaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterSecondary registerSecondary = db.RegisterSecondary.Find(id);
            if (registerSecondary == null)
            {
                return HttpNotFound();
            }
            return View(registerSecondary);
        }

        // GET: RegisterSecondaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterSecondaries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "registerID,firstName,lastName,businessUnit,hireDate,title")] RegisterSecondary registerSecondary)
        {
            if (ModelState.IsValid)
            {
                db.RegisterSecondary.Add(registerSecondary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registerSecondary);
        }

        // GET: RegisterSecondaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterSecondary registerSecondary = db.RegisterSecondary.Find(id);
            if (registerSecondary == null)
            {
                return HttpNotFound();
            }
            return View(registerSecondary);
        }

        // POST: RegisterSecondaries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "registerID,firstName,lastName,businessUnit,hireDate,title")] RegisterSecondary registerSecondary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registerSecondary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registerSecondary);
        }

        // GET: RegisterSecondaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterSecondary registerSecondary = db.RegisterSecondary.Find(id);
            if (registerSecondary == null)
            {
                return HttpNotFound();
            }
            return View(registerSecondary);
        }

        // POST: RegisterSecondaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegisterSecondary registerSecondary = db.RegisterSecondary.Find(id);
            db.RegisterSecondary.Remove(registerSecondary);
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
