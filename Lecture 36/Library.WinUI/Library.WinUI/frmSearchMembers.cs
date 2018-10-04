using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BLL;
using Libaray.BusinessObjects;
namespace Library.WinUI
{
    public partial class frmSearchMembers : Form
    {
        public frmSearchMembers()
        {
            InitializeComponent();
        }
        List<Member> members = new List<Member>();
        private void frmSearchMembers_Load(object sender, EventArgs e)
        {
            members = new MemberBLL().GetMembers();
            temp = members;
            this.dgvSearchMember.DataSource = temp;
        }
        List<Member> temp = new List<Member>();
        public Member SelectedMember { get; set; }
        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            var selected = from m in members
                           where m.Name.ToUpper().StartsWith(txtSearchMember.Text.ToUpper())
                           select m;
            temp = new List<Member>();
            foreach (var item in selected)
            {
                temp.Add(
                    new Member
                    {
                        Id=item.Id,
                        Name=item.Name,
                        FatherName=item.FatherName,
                        ContactNo=item.ContactNo,
                        CNIC=item.CNIC,
                        Gender=item.Gender,
                        Type=item.Type,
                        Photo=item.Photo,
                        Category=item.Category

                    });
            }
            this.dgvSearchMember.DataSource = temp;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.dgvSearchMember.CurrentCell.RowIndex > -1)
            {
                SelectedMember = new Member();
                SelectedMember = temp[dgvSearchMember.CurrentCell.RowIndex];
                this.Close();
            }
        }
    }
}
