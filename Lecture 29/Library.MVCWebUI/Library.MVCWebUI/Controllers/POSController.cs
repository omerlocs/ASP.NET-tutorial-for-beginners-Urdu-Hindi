using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.MVCWebUI.Controllers
{
    public class POSController : Controller
    {
        //
        // GET: /POS/

        public ActionResult Index()
        {
            return View();
        }

        public string Hello()
        {
            return "Hello, World MVC";
        }

    }
}
