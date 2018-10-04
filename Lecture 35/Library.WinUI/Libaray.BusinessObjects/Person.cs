using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libaray.BusinessObjects
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string Name)
        {
            this.Name = Name;
        }
        public Person(string Name,String FatherName):this(Name)
        {
            this.FatherName = FatherName;
        }
        public string Name
        {
            get
          ;
            set
           ;
        }

        public string FatherName
        {
            get;
            set;
        }

        public string ContactNo
        {
            get;
            set;
        }

        public string CNIC
        {
            get;
            set;
        }

        public bool Gender
        {
            get;
            set;
        }

        public void DoYourJob()
        {
            Console.WriteLine("The person is doing its job");
        }
    }
}
