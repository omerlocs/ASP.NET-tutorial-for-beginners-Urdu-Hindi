using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libaray.BusinessObjects
{
    public class Member : Person
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public MemberType Type { get; set; }
        public byte[] Photo { get; set; }

        public Member()
        {

        }
        public Member(String Name)
        {
            this.Name = Name;
        }
        public Member(String Name,String FatherName,String Category,int MemberId,MemberType MemberType):base(Name,FatherName)
        {
            this.Category = Category;
            this.Id = MemberId;
            this.Type = MemberType;
        }
        public void DoYourJob()
        {
            Console.WriteLine("The Member Job is to Recieve Books and Return Books");
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
