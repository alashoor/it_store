using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IT.Models;

namespace IT.Controllers
{
    public class RejectionRequestsController : Controller
    {
        private RejectionRequestsDBContext db = new RejectionRequestsDBContext();

        // GET: RejectionRequests
        public ActionResult Index()
        {
            return View(db.RejectionRequests.ToList());
        }

        // GET: RejectionRequests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejectionRequests rejectionRequests = db.RejectionRequests.Find(id);
            if (rejectionRequests == null)
            {
                return HttpNotFound();
            }
            return View(rejectionRequests);
        }

        // GET: RejectionRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RejectionRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rejectionRequestsID,serialNumber,barcode,serviceTag,businessArea,justification,costCenter,timeStamp")] RejectionRequests rejectionRequests)
        {
            if (ModelState.IsValid)
            {
                db.RejectionRequests.Add(rejectionRequests);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rejectionRequests);
        }

        // GET: RejectionRequests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejectionRequests rejectionRequests = db.RejectionRequests.Find(id);
            if (rejectionRequests == null)
            {
                return HttpNotFound();
            }
            return View(rejectionRequests);
        }

        // POST: RejectionRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rejectionRequestsID,serialNumber,barcode,serviceTag,businessArea,justification,costCenter,timeStamp")] RejectionRequests rejectionRequests)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rejectionRequests).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rejectionRequests);
        }

        // GET: RejectionRequests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejectionRequests rejectionRequests = db.RejectionRequests.Find(id);
            if (rejectionRequests == null)
            {
                return HttpNotFound();
            }
            return View(rejectionRequests);
        }

        // POST: RejectionRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RejectionRequests rejectionRequests = db.RejectionRequests.Find(id);
            db.RejectionRequests.Remove(rejectionRequests);
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
