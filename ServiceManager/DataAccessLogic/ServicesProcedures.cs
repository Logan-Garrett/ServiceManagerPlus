using Microsoft.Data.SqlClient;
using ServiceManager.DatabaseConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManager.DataAccessLogic
{
    public class ServicesProcedures : IServicesProcedures
    {
        private static readonly string dataSource = "Initial catalog=Services;";

        public void SelectAllServices()
        {
            string procedure = "[dbo].[SelectAllServices]";
            SelectAllServices(procedure, dataSource);
        }

        // Change to be called from outside location?
        private static void SelectAllServices(string procedure, string dataSource)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection(dataSource))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(procedure, conn);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
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
    }
}
