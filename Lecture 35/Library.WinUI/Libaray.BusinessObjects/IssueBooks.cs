using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libaray.BusinessObjects
{
   public  class IssueBooks
    {
       public int IssueNumber { get; set; }
       public DateTime IssueDate { get; set; }
       public Member Member { get; set; }
       public List<IssueBookLineItem> LineItems { get; set; }

       public IssueBooks()
       {
           if (this.LineItems == null)
               this.LineItems = new List<IssueBookLineItem>();
       }

       public int GetTotalQuantity()
       {
           int total = 0;
           foreach (var item in LineItems)
           {
               total += item.Quantity;
           }
           return total;
       }
    }
}
