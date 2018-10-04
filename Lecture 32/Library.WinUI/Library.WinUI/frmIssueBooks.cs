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
            if (frmsm.SelectedMember != null)
            {
                this.txtMemberCode.Text = frmsm.SelectedMember.Id.ToString();
                this.txtMemberName.Text = frmsm.SelectedMember.Name;
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            frmSearchBooks frmsb = new frmSearchBooks();
            frmsb.ShowDialog();
            if (frmsb.SelectedBook != null)
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

        private void txtBookCode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBookCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBookCode.Text.Trim() != string.Empty)
                {
                    BooksBLL bll = new BooksBLL();
                    bk = bll.GetBook().Where(b => b.Code.ToString() == txtBookCode.Text).Single<Books>();
                    this.txtTitle.Text = bk.Title;
                    this.txtAuthor.Text = bk.Author;
                    this.txtQty.Focus();
                }
            }
        }
        Books bk;
        IssueBooks ib = new IssueBooks();
        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtQty.Text.Trim() == string.Empty || txtQty.Text.Trim() == "0")
                {
                    e.Handled = true;
                    return;
                }
                object[] values = { txtBookCode.Text, txtTitle.Text, txtAuthor.Text, txtQty.Text };
                this.dgvIssueBooks.Rows.Add(values);
                ib.LineItems.Add(new IssueBookLineItem{
                    Book= bk,
                    Quantity=Convert.ToInt32(txtQty.Text)        }
                    );
                this.txtQty.Clear();
                this.txtAuthor.Clear();
                this.txtTitle.Clear();
                this.txtBookCode.Clear();
                this.txtBookCode.Focus();
                this.txtTotalBooks.Text = ib.GetTotalQuantity().ToString();
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            txtQty_KeyUp(sender, new KeyEventArgs( Keys.Enter));
        }
    }
}
