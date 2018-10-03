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
    public partial class frmFineCalculator : Form
    {
        public frmFineCalculator()
        {
            InitializeComponent();
        }
        MemberBLL mbll=new MemberBLL();
        private void frmFineCalculator_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = mbll.GetMembers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member selectedMember = (Member)this.comboBox1.SelectedItem;
            switch (selectedMember.Type)
            {
                case MemberType.Student:
                    {
                        IFineCalculator ifc = new StudentFineCalculator();
                        txtTotalFine.Text = ifc.CalculateFine(Convert.ToInt32(txtTotalDays.Text)).ToString();
                        break;
                    }
                default:
                    {
                        IFineCalculator ifc = new OtherFineCalculator();
                        txtTotalFine.Text = ifc.CalculateFine(Convert.ToInt32(txtTotalDays.Text)).ToString();
                        break;
                    }
                    
            }
        }
    }
}
