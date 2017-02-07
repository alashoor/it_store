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
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RejectionRequests
        public ActionResult Index(string costCentertxt, string searchString)
        {
            var costCenterLst = new List<string>();

            var costCenterQry = from d in db.Locations
                                orderby d.costCenter
                                select d.costCenter;

            costCenterLst.AddRange(costCenterQry.Distinct());
            ViewBag.rejectionRequestsCostCenter = new SelectList(costCenterLst);

            var rejectionRequests = from m in db.RejectionRequests
                         select m;


            if (!String.IsNullOrEmpty(searchString))
            {
                rejectionRequests = rejectionRequests.Where(s => s.serialNumber.Contains(searchString) || s.barcode.Contains(searchString) || s.serviceTag.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(costCentertxt))
            {
                rejectionRequests = from mc in db.RejectionRequests
                         where mc.Location.costCenter == costCentertxt
                         select mc;
            }

            return View(rejectionRequests);
        }

        // GET: RejectionRequests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejectionRequest rejectionRequest = db.RejectionRequests.Find(id);
            if (rejectionRequest == null)
            {
                return HttpNotFound();
            }
            return View(rejectionRequest);
        }

        // GET: RejectionRequests/Create
        public ActionResult Create()
        {
            ViewBag.locationID = new SelectList(db.Locations, "locationID", "costCenter");
            return View();
        }

        // POST: RejectionRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rejectionRequestsID,serialNumber,barcode,serviceTag,businessArea,justification,locationID,timestamp")] RejectionRequest rejectionRequest)
        {
            if (ModelState.IsValid)
            {
                db.RejectionRequests.Add(rejectionRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.locationID = new SelectList(db.Locations, "locationID", "costCenter", rejectionRequest.locationID);
            return View(rejectionRequest);
        }

        // GET: RejectionRequests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejectionRequest rejectionRequest = db.RejectionRequests.Find(id);
            if (rejectionRequest == null)
            {
                return HttpNotFound();
            }
            ViewBag.locationID = new SelectList(db.Locations, "locationID", "costCenter", rejectionRequest.locationID);
            return View(rejectionRequest);
        }

        // POST: RejectionRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rejectionRequestsID,serialNumber,barcode,serviceTag,businessArea,justification,locationID,timestamp")] RejectionRequest rejectionRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rejectionRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.locationID = new SelectList(db.Locations, "locationID", "costCenter", rejectionRequest.locationID);
            return View(rejectionRequest);
        }

        // GET: RejectionRequests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RejectionRequest rejectionRequest = db.RejectionRequests.Find(id);
            if (rejectionRequest == null)
            {
                return HttpNotFound();
            }
            return View(rejectionRequest);
        }

        // POST: RejectionRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RejectionRequest rejectionRequest = db.RejectionRequests.Find(id);
            db.RejectionRequests.Remove(rejectionRequest);
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
