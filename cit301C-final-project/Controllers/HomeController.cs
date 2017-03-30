using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cit301C_final_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Search for a specific pet.";

            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Add a new pet identification chip.";

            return View();
        }
    }
}