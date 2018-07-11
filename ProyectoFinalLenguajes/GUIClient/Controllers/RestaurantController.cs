using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUIClient.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Dishes()
        {
            return View();
        }
    }
}