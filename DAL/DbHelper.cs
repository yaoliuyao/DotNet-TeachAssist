using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbHelper
    {
        public static SqlConnection GetConnection(string database = "ta")
        {
            var connStr = $"server=.;database={database};integrated security=SSPI";
            var connection = new SqlConnection(connStr);
            connection.Open();
            return connection;
        }

        public static int DoExecuteNonQuery(string sql, params SqlParameter[] sqlParams)
        {
            using var connection = GetConnection();

            var command = new SqlCommand { CommandText = sql, Connection = connection };
            if (sqlParams != null)
            {
                command.Parameters.AddRange(sqlParams);
            }

            return command.ExecuteNonQuery();
        }
    }
}
