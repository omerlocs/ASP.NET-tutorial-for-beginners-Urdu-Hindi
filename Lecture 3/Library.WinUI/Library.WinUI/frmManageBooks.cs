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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Server=Asif-PC\SQL2012;Database=LibraryDB;Integrated Security=SSPI;";
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("insert into books(bookcode,bookauthor,bookpublisher,booktitle) values ({0},'{1}','{2}','{3}')", txtCode.Text, txtAuthor.Text, txtPublisher.Text, txtTitle.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Books Saved Successfully - Congratulations !!!!!", "Save Books");
            con.Close();
            cmd.Dispose();
        }
    }
}
