using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.MVCWebUI.Controllers
{
    public class LibraryController : Controller
    {
        //
        // GET: /Library/

        public ActionResult Book()
        {
            return View();
        }

    }
}
