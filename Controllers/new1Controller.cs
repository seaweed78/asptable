﻿using System;
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
    }
}