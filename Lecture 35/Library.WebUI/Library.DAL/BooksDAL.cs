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
    public class BooksDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet dsBooks=new DataSet();
        public int GetNextCode()
        {
            int NewCode;
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select isnull(max(bookcode),0)+1 as NextCode from books";
            object obj = cmd.ExecuteScalar();
            NewCode = Convert.ToInt32( obj.ToString());
            con.Close();
            cmd.Dispose();
            return NewCode;
        }
        public void DeleteBook(Books book)
        {
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("delete from books where bookcode={0}",book.Code);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public void SaveBooks(bool isEditMode,Books book)
        {
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            if (isEditMode == true)
                cmd.CommandText = string.Format("update books set bookauthor='{1}',bookpublisher='{2}',booktitle='{3}' where bookcode={0}", book.Code, book.Author, book.Publisher, book.Title);
            else
                cmd.CommandText = string.Format("insert into books(bookcode,bookauthor,bookpublisher,booktitle) values ({0},'{1}','{2}','{3}')", book.Code, book.Author, book.Publisher, book.Title);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public List<Books> GetBook()
        {
            List<Books> temp = new List<Books>();
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from books";
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                temp.Add(new Books
                {
                    Code = Convert.ToInt32(dr["BookCode"].ToString()),
                    Title = dr["BookTitle"].ToString(),
                    Author = dr["BookAuthor"].ToString(),
                    Publisher = dr["BookPublisher"].ToString()
                });
            }
            return temp;
        }
        public DataSet GetBooks()
        {
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from books";
            da = new SqlDataAdapter(cmd);
            da.Fill(dsBooks);
            con.Close();
            cmd.Dispose();
            return dsBooks;
        }
    }
}
