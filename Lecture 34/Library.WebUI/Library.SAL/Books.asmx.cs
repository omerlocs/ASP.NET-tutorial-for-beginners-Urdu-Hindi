using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Libaray.BusinessObjects;
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
        public List<Libaray.BusinessObjects.Books> GetBook()
        {
            return new BooksDAL().GetBook();
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
    }
}
