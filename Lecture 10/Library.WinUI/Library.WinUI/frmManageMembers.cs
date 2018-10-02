using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libaray.BusinessObjects;
using Library.BLL;
using System.Drawing.Imaging;
using System.IO;
namespace Library.WinUI
{
    public partial class frmManageMembers : Form
    {
        MemberBLL mbll;
        public frmManageMembers()
        {
            InitializeComponent();
        }
        public frmManageMembers(MemberBLL mbll)
        {
            InitializeComponent();
            this.mbll = mbll;
            this.mbll.newArrivals += mbll_newArrivals;
        }

        void mbll_newArrivals(object sender, MemberEnrollmentEventArgs e)
        {
            MessageBox.Show("Member Saved Successfully!!!!");    
        }
        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)
                this.pbxMemberPhoto.Image = Image.FromFile(ofd.FileName);
        }

        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            lbxMemberType.DataSource = Enum.GetValues(typeof(MemberType));
            GetNextCode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            m.Name = this.txtMemberName.Text;
            m.FatherName = txtFatherName.Text;
            m.Gender = rbxfemale.Checked;
            m.Type = (MemberType)lbxMemberType.SelectedItem;
            m.City = cbxCity.Text;
            m.CNIC = txtCNIC.Text;
            string category = chbGuest.Checked ? "Guest" : string.Empty;
            category += chbPermanent.Checked ? " Permanent" : string.Empty;
            category += chbTemporary.Checked ? " Temporary" : string.Empty;
            m.Category = category;
            MemoryStream ms = new MemoryStream();
            pbxMemberPhoto.Image.Save(ms, ImageFormat.Jpeg);
            m.Photo = ms.ToArray();
            mbll.SaveMember(m);
        }
        private void GetNextCode()
        {
            this.txtMembershipID.Text = new MemberBLL().GetNextCode().ToString();
        }
    }
}
