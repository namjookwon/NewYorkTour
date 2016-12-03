using NewYork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace NewYork.Controllers
{
    public class StoreController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Store
        public ActionResult Index()
        {
            var shows = db.Shows.Include(s => s.Genre);
            return View(shows.ToList());
        }

        public ActionResult Details(int id)
        {
            var show = db.Shows.Find(id);

            return View(show);
        }
    }
}