using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libaray.BusinessObjects
{
    public class Books
    {
        public Books()
        {
            if(this.BookList==null)
            this.BookList = new List<Books>();
        }
        public int Code { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public string Publisher { get; set; }

        public List<Books> BookList { get; set; }
    }
}
