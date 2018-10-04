using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libaray.BusinessObjects;
using System.Data;
using System.Data.SqlClient;

namespace Library.DAL
{
    public class MemberDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet dsMembers = new DataSet();
        public int GetNextCode()
        {
            int NewCode;
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select isnull(max(MemberId),0)+1 as NextCode from Members";
            object obj = cmd.ExecuteScalar();
            NewCode = Convert.ToInt32(obj.ToString());
            con.Close();
            cmd.Dispose();
            return NewCode;
        }
        public void SaveMember(Member m)
        {
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Members(Name,FatherName,CNIC,MemberType,Category,Photo,Gender,City) values "
                + "(@Name,@FatherName,@CNIC,@MemberType,@Category,@Photo,@Gender,@City);";
            cmd.Parameters.AddWithValue("@Name", m.Name);
            cmd.Parameters.AddWithValue("@FatherName", m.FatherName);
            cmd.Parameters.AddWithValue("@CNIC", m.CNIC);
            cmd.Parameters.AddWithValue("@MemberType", Convert.ToInt32(m.Type));
            cmd.Parameters.AddWithValue("@Category", m.Category);

            cmd.Parameters.AddWithValue("@Photo", m.Photo);
            cmd.Parameters.AddWithValue("@Gender", Convert.ToInt32(m.Gender));
           
            cmd.Parameters.AddWithValue("@City", m.City);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();

        }

        public List<Member> GetMembers()
        {
            con = new SqlConnection();
            con.ConnectionString = DBHelperDAL.ConnectionString;
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from members";
            List<Member> temp = new List<Member>();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Member m = new Member( reader["Name"].ToString(),reader["FatherName"].ToString(),reader["Category"].ToString(), Convert.ToInt32( reader["MemberId"].ToString()),(MemberType)Convert.ToInt32(reader["MemberType"].ToString()));
                temp.Add(m);
            }
            reader.Close();
            con.Close();
            cmd.Dispose();
            return temp;
        }
    }
}
