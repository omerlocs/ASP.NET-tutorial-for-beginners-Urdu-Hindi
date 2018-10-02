using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libaray.BusinessObjects;
using Library.DAL;
namespace Library.BLL
{
    public class MemberBLL
    {
        public int GetNextCode()
        {
            return new MemberDAL().GetNextCode();
        }
        public void SaveMember(Member m)
        {
            new MemberDAL().SaveMember(m);
        }
    }
}
