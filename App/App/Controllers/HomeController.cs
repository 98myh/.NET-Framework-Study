using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewBag.Arr = new string[]
            //{
            //    "alpha",
            //    "beta",
            //    "gamma"
            //};

            ViewBag.Book = new Book
            {
                Title = "칼의 노래",
                Writer = "김훈"
            };

            return View();
        }
    }
}