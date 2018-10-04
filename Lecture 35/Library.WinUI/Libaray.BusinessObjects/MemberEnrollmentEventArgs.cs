using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libaray.BusinessObjects
{
    public class MemberEnrollmentEventArgs:EventArgs
    {
        public Member NewMember { get; set; }
        public MemberEnrollmentEventArgs(Member newMember)
        {
            this.NewMember = newMember;
        }
    }
}
