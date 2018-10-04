using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Libaray.BusinessObjects;
namespace Library.DAL
{
    public class IssueBookDAL
    {
        SqlConnection con;
        SqlCommand cmd;

        public int GetNextSerial()
        {
            int nextserial = 1;
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select isnull(max(IssueNo),0) +1 as IssueNo from IssueBooks";
            nextserial = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            cmd.Dispose();
            return nextserial;
        }
        public void SaveIssueBooks(IssueBooks ib)
        {
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            SqlTransaction trans = con.BeginTransaction();
            cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                cmd.Transaction = trans;

                cmd.CommandText = string.Format("insert into IssueBooks(IssueNo,IssueDate,MemberCode) values({0},'{1}',{2})", ib.IssueNumber, ib.IssueDate.ToString("MM/dd/yyyy"), ib.Member.Id);
                cmd.ExecuteNonQuery();
                int serialno = 1;
                foreach (var item in ib.LineItems)
                {
                    cmd.CommandText = string.Format("insert into IssueBooksDetail(IssueNo,SerialNo,BookCode,BookQuantity)  values({0},{1},{2},{3})", ib.IssueNumber, serialno++, item.Book.Code, item.Quantity);
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();

            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw;
            }
                       con.Close();
            cmd.Dispose();
        }
    }
}
