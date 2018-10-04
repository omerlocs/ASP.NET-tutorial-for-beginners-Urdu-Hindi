using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Library.DAL
{
   public class DBHelperDAL
    {
       public static string ConnectionString
       {
           get
           {
               return ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString;
           }
       }
    }
}
