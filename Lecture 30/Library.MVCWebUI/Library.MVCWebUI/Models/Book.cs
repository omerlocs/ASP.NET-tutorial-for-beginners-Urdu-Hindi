using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.MVCWebUI.Models
{
    public class Book
    {
        public Book()
        {
            if(this.BookList ==null)
            this.BookList = new List<Book>();
        }
        public int Code { get; set; }
        public String Title { get; set; }
        public String Publisher { get; set; }
        public String Author { get; set; }

        public List<Book> BookList { get; set; }
    }
}