using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CMS_Spedizioni.Models
{
    public class Shared
    {
        public static SqlConnection GetConnectionDb()
        {
            string con = ConfigurationManager.ConnectionStrings["CMS_Spedizione"].ToString();
            SqlConnection sql = new SqlConnection(con);
            return sql;
        }

        public static SqlDataReader GetReaderAfterSQL(string SQLCommandText, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(SQLCommandText, sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            return reader;
        }

    }
}