using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinUI
{
    public partial class frmIssueBooks : Form
    {
        public frmIssueBooks()
        {
            InitializeComponent();
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            frmSearchMembers frmsm = new frmSearchMembers();
            frmsm.ShowDialog();
            if(frmsm.SelectedMember != null)
            {
                this.txtMemberCode.Text = frmsm.SelectedMember.Id.ToString();
                this.txtMemberName.Text = frmsm.SelectedMember.Name;
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            frmSearchBooks frmsb = new frmSearchBooks();
            frmsb.ShowDialog();
            if(frmsb.SelectedBook !=null)
            {
                this.txtBookCode.Text = frmsb.SelectedBook.Code.ToString();
                this.txtTitle.Text = frmsb.SelectedBook.Title;
            }
        }

        private void txtMemberCode_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtMemberCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSearchMembers frmssm = new frmSearchMembers();
                frmssm.ShowDialog();
            }
        }
    }
}
