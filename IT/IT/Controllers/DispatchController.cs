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
    public class DispatchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dispatch
        public ActionResult Index(string costCentertxt, string searchString)
        {
            var costCenterLst = new List<string>();

            var costCenterQry = from d in db.Locations
                                orderby d.costCenter
                                select d.costCenter;

            costCenterLst.AddRange(costCenterQry.Distinct());
            ViewBag.assetCostCenter = new SelectList(costCenterLst);

            var assets = from m in db.Assets
                         select m;


            if (!String.IsNullOrEmpty(searchString))
            {
                assets = assets.Where(s => s.serialNumber.Contains(searchString) || s.barcode.Contains(searchString) || s.seviceTag.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(costCentertxt))
            {
                assets = from mc in db.Assets
                         where mc.Location.costCenter == costCentertxt
                         select mc;
            }

            return View(assets);
        }

        // GET: Dispatch/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asset asset = db.Assets.Find(id);
            if (asset == null)
            {
                return HttpNotFound();
            }
            return View(asset);
        }

        // GET: Dispatch/Create
        public ActionResult Create()
        {
            ViewBag.locationID = new SelectList(db.Locations, "locationID", "costCenter");
            ViewBag.modelID = new SelectList(db.Models, "modelID", "modelName");
            return View();
        }

        // POST: Dispatch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "assetlID,modelID,serialNumber,barcode,seviceTag,status,remarks,ticketNumber,userName,DHLPolicy,locationID,timestamp")] Asset asset)
        {
            if (ModelState.IsValid)
            {
                db.Assets.Add(asset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.locationID = new SelectList(db.Locations, "locationID", "costCenter", asset.locationID);
            ViewBag.modelID = new SelectList(db.Models, "modelID", "modelName", asset.modelID);
            return View(asset);
        }

        // GET: Dispatch/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asset asset = db.Assets.Find(id);
            if (asset == null)
            {
                return HttpNotFound();
            }
            ViewBag.locationID = new SelectList(db.Locations, "locationID", "costCenter", asset.locationID);
            ViewBag.modelID = new SelectList(db.Models, "modelID", "modelName", asset.modelID);
            return View(asset);
        }

        // POST: Dispatch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "assetlID,modelID,serialNumber,barcode,seviceTag,status,remarks,ticketNumber,userName,DHLPolicy,locationID,timestamp")] Asset asset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.locationID = new SelectList(db.Locations, "locationID", "costCenter", asset.locationID);
            ViewBag.modelID = new SelectList(db.Models, "modelID", "modelName", asset.modelID);
            return View(asset);
        }

        // GET: Dispatch/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asset asset = db.Assets.Find(id);
            if (asset == null)
            {
                return HttpNotFound();
            }
            return View(asset);
        }

        // POST: Dispatch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Asset asset = db.Assets.Find(id);
            db.Assets.Remove(asset);
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
