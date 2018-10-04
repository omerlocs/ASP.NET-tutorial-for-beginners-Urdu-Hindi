using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
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
            string actionUrl = "http://localhost:11969/Books.asmx/SaveBook";
            HttpContent code = new StringContent(book.Code.ToString());
            HttpContent name = new StringContent(book.Title);
            HttpContent author = new StringContent(book.Author);
            HttpContent publisher = new StringContent(book.Publisher);
            HttpContent EditMode = new StringContent(isEditMode.ToString());
            using (var client = new HttpClient())
            {
                using (var formdata = new MultipartFormDataContent())
                {
                    formdata.Add(code,book.Code.ToString(),book.Code.ToString());
                    formdata.Add(name,book.Title,book.Title);
                    formdata.Add(author,book.Author,book.Author);
                    formdata.Add(publisher,book.Publisher,book.Publisher);
                    formdata.Add(EditMode, isEditMode.ToString(), isEditMode.ToString());
                    var respsone = client.PostAsync(actionUrl,formdata).Result;
                    if(respsone.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Books Saved Successfully - Congratulations !!!!!", "Save Books");
                    }
                    else
                    {
                        MessageBox.Show("Error Saving - OHHHHHHHHHH !!!!!", "Save Books");
            
                    }
                }
            }
            //bbll.SaveBooks(isEditMode, book);
            
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
            if (frmsb.SelectedBook != null)
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
