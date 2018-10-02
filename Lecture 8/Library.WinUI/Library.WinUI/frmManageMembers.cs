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
    public partial class frmManageMembers : Form
    {
        public frmManageMembers()
        {
            InitializeComponent();
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)
                this.pbxMemberPhoto.Image = Image.FromFile(ofd.FileName);
        }
    }
}
