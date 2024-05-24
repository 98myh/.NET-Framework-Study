using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class BookController : Controller
    {
        // GET: Board
        public ActionResult Index()
        {
            return View();
        }
    }
}