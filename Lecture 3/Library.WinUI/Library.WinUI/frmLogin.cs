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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" && txtPassword.Text == "abc")
                this.Close();
            else
                MessageBox.Show("Invalid User Name and Password!!!!");
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            Control c = sender as Control;
            c.BackColor = Color.Yellow;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            Control c = sender as Control;
            c.BackColor = Color.White;
        }
    }
}
