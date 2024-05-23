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
        public ActionResult List()
        {
            DocumentActs documentActs = new DocumentActs();
            MemberActs memberActs = new MemberActs();

            var documents = documentActs.GetDocuments();
            var member = memberActs.GetMember(1);

            //View()는 인자를 하나만 가질 수 있음
            //두개 이상을 전달하려면 ViewBag 또는 ViewData 사용
            //ViewBag.Member = member;
            ViewData["Member"] = member;

            return View(documents);
        }

        
    }
}