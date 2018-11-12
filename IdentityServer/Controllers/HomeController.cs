﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sina.Trainings.AECustomIdentity.Controllers
{
    public class HomeController : Controller
    {
        private MAPContext db;

        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Client")]
        public ActionResult IndexClient()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult IndexAdmin()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. It will show to only authorized People";

            return View();
        }
        public ActionResult Register()
        {
            db = new MAPContext();
            ViewBag.Roles = new SelectList(db.Roles.Where(a => !a.Name.Contains("SuperAdmin")), "Name", "Name");
            return View();
        }
        public ActionResult HomeAdmin()
        {
            db = new MAPContext();
            return View();
        }
        public ActionResult HomeRessource()
        {
            db = new MAPContext();
            return View();
        }
        public ActionResult HomeApplicant()
        {
            db = new MAPContext();
            return View();
        }
        public ActionResult HomeClient()
        {
            db = new MAPContext();
            return View();
        }

    }
}