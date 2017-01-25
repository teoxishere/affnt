using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using affnt.Models;

namespace affnt.Controllers
{
    public class MatchesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Matches
        public ActionResult Index()
        {
            Person per = db.People
                        .Where(p => p.LookingFor == "F")
                        .OrderBy(p => p.City)
                        .FirstOrDefault();
            return View(per);
        }


        public ActionResult Create()
        {
            return View();
        }





    }
       
}
