﻿using zoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zoo.Controllers
{
    public class SalesAssociateController : Controller
    {
        // GET: SalesAssociate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return RedirectToAction("Index", "Login");
        }

        public ActionResult Sales()
        {
            ViewBag.Message = "Your sales entry page.";

            return View();
        }

        public ActionResult Inventory()
        {
            ViewBag.Message = "Check for items in our stock.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch with your coworkers.";

            return View();
        }
        [HttpPost]
        public ActionResult Sell(Inventory userModel)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Check(Inventory userModel)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Employee userModel)
        {

            return View();
        }
        public ActionResult contactInfo(string f_name, string l_name)
        {
            using (team4zooEntities db = new team4zooEntities())
            {
                var movies = from m in db.Employees
                             where m.ReleaseDate > new DateTime(1984, 6, 1)
                             select m;

                return View(movies.ToList());
            }

        }
    }
}