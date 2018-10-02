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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            frmLogin frml = new frmLogin();
            frml.ShowDialog();
        }

        private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageBooks frmmb = new frmManageBooks();
            frmmb.MdiParent = this;
            frmmb.Show();
        }
    }
}
