﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers {
    public class SalesRecordsController : Controller {
        // GET: SalesRecordsController
        public ActionResult Index() {
            return View();
        }

        public ActionResult SimpleSearch() {
            return View();
        }

        public ActionResult GroupingSearch() {
            return View();
        }
    }
}