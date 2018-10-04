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
namespace Library.WinUI
{
    public partial class frmMainScreen : Form
    {
        MemberBLL mbll = new MemberBLL();
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            frmLogin frml = new frmLogin();
            frml.ShowDialog();

            frmWidgetMembers frmwm = new frmWidgetMembers(mbll);
            frmwm.MdiParent = this;
            frmwm.Show();
        }

        private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageBooks frmmb = new frmManageBooks();
            frmmb.MdiParent = this;
            frmmb.Show();
        }

        private void manageMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageMembers frmmm = new frmManageMembers(mbll);
            frmmm.MdiParent = this;
            frmmm.Show();
        }

        private void fineCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFineCalculator frmfc = new frmFineCalculator();
            frmfc.MdiParent = this;
            frmfc.Show();
        }

        private void viewBooksListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportViewer frmrv = new frmReportViewer();
            frmrv.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueBooks frmib = new frmIssueBooks();
            frmib.Show();
        }
    }
}
