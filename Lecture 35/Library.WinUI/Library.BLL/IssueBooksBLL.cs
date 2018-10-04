using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Libaray.BusinessObjects;
namespace Library.BLL
{
    public class IssueBooksBLL
    {
        public int GetNextSerial()
        {
            return new IssueBookDAL().GetNextSerial();
        }
        public void SaveIssue(IssueBooks ib)
        {
            new IssueBookDAL().SaveIssueBooks(ib);
        }
    }
}
