using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libaray.BusinessObjects
{
    public class IssueBookLineItem
    {
        public Books Book { get; set; }
        public int Quantity { get; set; }
        public IssueBookLineItem()
        {
            this.Book = new Books();
        }
    }
}
