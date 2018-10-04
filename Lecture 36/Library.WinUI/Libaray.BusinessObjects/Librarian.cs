using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libaray.BusinessObjects
{
    public class Librarian : Person
    {

        public int EmployeeCode
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public double Salary
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void DoYourJob()
        {
            Console.WriteLine("The Job of Librarian is Manage Books");
        }
        public void DoYourJob(String Task)
        {
            Console.WriteLine("The Librarian has done this Task " + Task);
        }
    }
}
