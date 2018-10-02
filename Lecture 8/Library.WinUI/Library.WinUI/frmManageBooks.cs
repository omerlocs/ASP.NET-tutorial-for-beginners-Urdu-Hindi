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
    public partial class frmManageBooks : Form
    {
        public frmManageBooks()
        {
            InitializeComponent();
        }
        
        private void frmManageBooks_Load(object sender, EventArgs e)
        {
            GetNextBookCode();
        }

        private void GetNextBookCode()
        {
            txtCode.Text = bbll.GetNextCode().ToString();
        }
        bool isEditMode = false;
        BooksBLL bbll = new BooksBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Code = Convert.ToInt32(txtCode.Text);
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Publisher = txtPublisher.Text;
            bbll.SaveBooks(isEditMode, book);
            MessageBox.Show("Books Saved Successfully - Congratulations !!!!!", "Save Books");
            
            GetNextBookCode();
            ClearControls();
            txtTitle.Focus();
            isEditMode = false;
        }
        private void ClearControls()
        {
            this.txtAuthor.Clear();
            this.txtPublisher.Clear();
            this.txtTitle.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchBooks frmsb = new frmSearchBooks();
            frmsb.ShowDialog();
            if (frmsb.SelectedBook!=null)
            {
                txtTitle.Text = frmsb.SelectedBook.Title;
                txtCode.Text = frmsb.SelectedBook.Code.ToString();
                txtAuthor.Text = frmsb.SelectedBook.Author;
                txtPublisher.Text = frmsb.SelectedBook.Publisher;
                isEditMode = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            ClearControls();
            GetNextBookCode();
            this.txtTitle.Focus();
            isEditMode = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Code = Convert.ToInt32(txtCode.Text);
            bbll.DeleteBook(book);
            MessageBox.Show("Books Deleted Successfully - Congratulations !!!!!", "Remove Book");
            GetNextBookCode();
            ClearControls();
            txtTitle.Focus();
            isEditMode = false;
        
        }
    }
}
