using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        //GET: ADMIN View Insuree/Admin
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            //Add logic to calculate a quote
            //Start with $50 per month
            if (ModelState.IsValid)
            {
                insuree.Quote = Convert.ToDecimal(50);
                //User age parameters
                var age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                //18 or under
                if (age <= 18)
                {
                insuree.Quote += 100;
                }
                //19 to 25
                else if (age > 18 && age <= 25)
                {
                insuree.Quote += 50;
                }
                //Over 25
                else
                {
                insuree.Quote += 25;
                }
                //Car age parameters
                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                else if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }
                //Porche parameters
                var carmake = insuree.CarMake.ToLower();
                var carmodel = insuree.CarModel.ToLower();
                if (carmake == "porche")
                {
                    insuree.Quote += 25;
                }
                if (carmake == "porche" && carmodel == "911 carrera")
                {
                    insuree.Quote += 25;
                }
                //Speeding Tickets
                insuree.Quote += (10 * insuree.SpeedingTickets);
                //DUI Add 25%
                if (insuree.DUI == true)
                {
                    insuree.Quote = (insuree.Quote / 4) + insuree.Quote;
                }
                //Full Coverage?
                if (insuree.CoverageType == true)
                {
                    insuree.Quote = (insuree.Quote / 2) + insuree.Quote;
                }
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
