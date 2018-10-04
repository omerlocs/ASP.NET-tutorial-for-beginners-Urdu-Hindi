using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace POS
{
    public partial class wfrmProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=Asif-PC\\SQL2012;database=POS_db;Integrated Security=SSPI;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("insert into Product(Code,Name,Price,UnitOfMeasure) values ({0},N'{1}',{2},N'{3}')", txtCode.Text, txtProductName.Text, txtProductPrice.Text, txtUnitOfMeasure.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            lblMessage.Text = "اشیا کامیاپی سے رح ہو";
        }
    }
}