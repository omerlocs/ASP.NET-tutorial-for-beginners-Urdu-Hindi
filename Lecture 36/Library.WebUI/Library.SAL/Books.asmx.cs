using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Libaray.BusinessObjects;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Runtime.Serialization.Json;
using Library.DAL;
using System.Data;
namespace Library.SAL
{
    /// <summary>
    /// Summary description for Books
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Books : System.Web.Services.WebService
    {
        [WebMethod]
        public int GetNextCode()
        {
           return new BooksDAL().GetNextCode() ;
        }
        [WebMethod]
        public void DeleteBook(Libaray.BusinessObjects.Books book)
        {
            new BooksDAL().DeleteBook(book);
        }
        [WebMethod]
        public void SaveBooks(bool isEditMode, Libaray.BusinessObjects.Books book)
        {
            new BooksDAL().SaveBooks(isEditMode, book);
        }
        [WebMethod]
        public void SaveBook()
        {
            Libaray.BusinessObjects.Books book = new Libaray.BusinessObjects.Books();
            bool isEditMode = false;
            HttpContext postedContext = HttpContext.Current;
            HttpFileCollection files = postedContext.Request.Files;
            book.Code = Convert.ToInt32( files[0].FileName);
            book.Title = files[1].FileName;
            book.Author = files[2].FileName;
            book.Publisher = files[3].FileName;
            isEditMode = Convert.ToBoolean(files[4].FileName);
            new BooksDAL().SaveBooks(isEditMode, book);
        }
        [WebMethod]
        public void GetBook()
        {
            List<Libaray.BusinessObjects.Books> bs = new BooksDAL().GetBook();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "json;";
            var data = js.Serialize(bs);
            Context.Response.Write(data);
        }
        [WebMethod]
        public DataSet GetBooks()
        {
            return new BooksDAL().GetBooks();
        }
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string LoBatao()
        {
            return "LObatao";
        }
    }
}
