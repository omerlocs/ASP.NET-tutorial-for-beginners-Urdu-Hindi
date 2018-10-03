using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library.BLL;
using Libaray.BusinessObjects;
namespace Library.WebUI
{
    public partial class wfrmBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Books b = new Books();
            b.Code = Convert.ToInt32(txtBookCode.Text);
            b.Author = txtBookAuthor.Text;
            b.Publisher = txtBookPublisher.Text;
            b.Title = txtBookTitle.Text;
            BooksBLL bbll = new BooksBLL();
            bbll.SaveBooks(false, b);
            lblMessage.Text = "Books Saved Successfully!";
        }
    }
}