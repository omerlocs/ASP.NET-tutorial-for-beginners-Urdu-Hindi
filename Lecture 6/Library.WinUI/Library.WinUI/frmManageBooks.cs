using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library.WinUI
{
    public partial class frmManageBooks : Form
    {
        public frmManageBooks()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void frmManageBooks_Load(object sender, EventArgs e)
        {
            GetNextBookCode();
        }

        private void GetNextBookCode()
        {
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select isnull(max(bookcode),0)+1 as NextCode from books";
            object obj = cmd.ExecuteScalar();
            txtCode.Text = obj.ToString();
            con.Close();
            cmd.Dispose();
        }
        bool isEditMode = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            if (isEditMode == true)
                cmd.CommandText = string.Format("update books set bookauthor='{1}',bookpublisher='{2}',booktitle='{3}' where bookcode={0}", txtCode.Text, txtAuthor.Text, txtPublisher.Text, txtTitle.Text);
            else
            cmd.CommandText = string.Format("insert into books(bookcode,bookauthor,bookpublisher,booktitle) values ({0},'{1}','{2}','{3}')", txtCode.Text, txtAuthor.Text, txtPublisher.Text, txtTitle.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Books Saved Successfully - Congratulations !!!!!", "Save Books");
            con.Close();
            cmd.Dispose();
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
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("delete from books where bookcode={0}", txtCode.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Books Deleted Successfully - Congratulations !!!!!", "Remove Book");
            con.Close();
            cmd.Dispose();
            GetNextBookCode();
            ClearControls();
            txtTitle.Focus();
            isEditMode = false;
        
        }
    }
}
