using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libaray.BusinessObjects
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string CNIC { get; set; }
        public string City { get; set; }
        public bool Gender { get; set; }
        public string Category { get; set; }
        public MemberType Type { get; set; }
        public byte[] Photo { get; set; }
    }
}
