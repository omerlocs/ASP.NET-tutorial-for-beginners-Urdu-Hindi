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
    public partial class frmWidgetMembers : Form
    {
        public frmWidgetMembers()
        {
            InitializeComponent();
        }
        MemberBLL Mbll;
        public frmWidgetMembers(MemberBLL mbll):this()
        {
            
            this.Mbll = mbll;
            this.Mbll.newArrivals += Mbll_newArrivals;
        }

        void Mbll_newArrivals(object sender, Libaray.BusinessObjects.MemberEnrollmentEventArgs e)
        {
            object[] values = { DateTime.Now.Date.ToShortDateString(), e.NewMember.Name };
            this.dataGridView1.Rows.Add(values);
        }
    }
}
