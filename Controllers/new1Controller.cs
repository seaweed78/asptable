using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice5.Models;

namespace practice5.Controllers
{
    public class new1Controller : Controller
    {
        // GET: new1
        practice5koEntities db = new practice5koEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult new1ko()
        {
            List<table1> all_data = db.table1.ToList();
            return View(all_data);
        }

        public ActionResult hewlo()
        {
            return View();
        }

        public ActionResult SaveData(table1 table1)
        {
            db.table1.Add(table1);
            db.SaveChanges();
            return RedirectToAction("new1ko");
        }

        public ActionResult edit(int id)
        {
            table1 data = db.table1.Find(id);
            return View(data);
        }

        public ActionResult UpdateData(table1 obj1)
        {
            db.Entry(obj1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("new1ko");
        }
    }
}