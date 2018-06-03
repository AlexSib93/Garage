using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garage.Controllers
{
    public class HomeController : Controller
    {
        private GarageContext db = new GarageContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Orders()
        {
            IEnumerable<Order> orders = db.Orders;
            ViewBag.Orders = orders;

            return View(orders);
        }
    }
}