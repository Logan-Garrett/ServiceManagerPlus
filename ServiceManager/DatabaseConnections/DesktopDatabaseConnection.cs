using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ServiceManager.DatabaseConnections
{
    public class DesktopDatabaseConnection
    {
        // Change to another place
        private static string dataSource = "Data Source=(local);Initial catalog=Services;"
        + "Integrated Security=SSPI;Encrypt=False";
        private static string query = "SELECT * FROM [Services].[dbo].[ServiceInfo];";

        private static void CreateConnection(string query, string dataSource)
        {
            using (SqlConnection conn = new SqlConnection(dataSource))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine(String.Format(reader[0].ToString()));
                    Console.WriteLine(String.Format(reader[1].ToString()));
                    Console.WriteLine(String.Format(reader[2].ToString()));
                    Console.WriteLine(String.Format(reader[3].ToString()));
                    Console.WriteLine(String.Format(reader[4].ToString()));
                }
                conn.Close();
            }
        }

        private static void CreateCommand(string query, string dataSource)
        {
            /*
            SqlConnection conn = CreateConnection(dataSource);
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.Connection.Open();
            int exectionStatus = sqlCommand.ExecuteNonQuery();
            */

            CreateConnection(query, dataSource);
        }

        // Move this proc later.
        public static void CallProcedure()
        {
            CreateCommand(query, dataSource);
        }

    }
}
