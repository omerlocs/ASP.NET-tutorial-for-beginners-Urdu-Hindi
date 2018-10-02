using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Data Providers SQL Server
using System.Data; // Data Set

namespace LMS.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=Asif-PC\\SQL2012;Database=LibraryDB;User Id=sa;Password=123456";// "Server=Asif-PC\\SQL2012;Database=LibraryDB;Integrated Security=SSPI;";
            con.Open();
            Console.WriteLine("Connected to SQL Server Successfully::)");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Books(BookCode,BookTitle,BookAuthor,BookPublisher) values (2,'Head First C#','Willey','Orielly');";
            cmd.ExecuteNonQuery();
            Console.WriteLine("Book Saved Successfully!~!!!!");
            con.Close();
            cmd.Dispose();




            Console.ReadKey();
        }
    }
}
