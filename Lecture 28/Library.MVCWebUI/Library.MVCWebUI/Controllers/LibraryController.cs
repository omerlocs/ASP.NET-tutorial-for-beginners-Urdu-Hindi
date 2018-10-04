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

        public ActionResult Book(int? Code)
        {
            Books b = new Books();
            
            if (!Code.HasValue)
                b.Code = new BooksDAL().GetNextCode();
            else
                b = new BooksDAL().GetBook().Where(bk => bk.Code == Code.Value).First<Books>();
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
        public ActionResult DeleteBook(int? Code)
        {
            new BooksDAL().DeleteBook(new Books {Code=Code.Value });
            return RedirectToAction("Book");
        }
        public ActionResult ChangeBook(int? Code)
        {
            return RedirectToAction("Book", new {Code=Code.Value });
        }
        public ActionResult Students()
        {
            return View();
        }

    }
}
