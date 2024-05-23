using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BoardController : Controller


    {

        // GET: Board
        public ActionResult List(int? id)
        {

            if (id == null)
            {
                return Content("Error Message #1");
            }

            DocumentActs documentActs = new DocumentActs();
            var documents = documentActs.GetDocuments();

            return View(documents);
        }

        
    }
}