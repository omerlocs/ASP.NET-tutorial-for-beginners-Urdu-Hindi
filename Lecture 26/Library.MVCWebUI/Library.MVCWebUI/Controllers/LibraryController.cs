using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Libaray.BusinessObjects;
using Library.DAL;
namespace Library.MVCWebUI.Controllers
{
    public class LibraryController : Controller
    {
        //
        // GET: /Library/

        public ActionResult Book()
        {
            Books b = new Books();
            b.Code = new BooksDAL().GetNextCode();
            b.BookList = new BooksDAL().GetBook();
            return View(b);
        }
        [HttpPost]
        public ActionResult Book(Books b)
        {
            int i = 0;
            BooksDAL bdal = new BooksDAL();
            bdal.SaveBooks(false, b);
            return View(b);
        }
        public ActionResult Students()
        {
            return View();
        }

    }
}
