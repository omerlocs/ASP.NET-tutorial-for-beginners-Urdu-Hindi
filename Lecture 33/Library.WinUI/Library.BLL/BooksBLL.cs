using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libaray.BusinessObjects;
using Library.DAL;
using System.Data;
namespace Library.BLL
{
    public class BooksBLL
    {
        public int GetNextCode()
        {
            return new BooksDAL().GetNextCode();
        }
        public void DeleteBook(Books book)
        {
            new BooksDAL().DeleteBook(book);
        }
        public void SaveBooks(bool isEditMode,Books book)
        {
            BooksDAL bdal = new BooksDAL();
            bdal.SaveBooks(isEditMode,book);
        }
        public List<Books> GetBook()
        {
            return new BooksDAL().GetBook();
        }
        public DataSet GetBooks()
        {
            return new BooksDAL().GetBooks();
        }
    }
}
