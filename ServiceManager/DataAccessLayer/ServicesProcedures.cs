using Microsoft.Data.SqlClient;
using ServiceManager.DatabaseConnections;
using System;
using System.Data;

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
            try
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
            catch (Exception ex)
            {
                // Log to DB.
            }
        }

        // Possibly Update to include an Auto Enumerated id that is unique
        public void InsertServiceinformation(Serviceinformation serviceinformation)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ServiceName", typeof(string));
            dataTable.Columns.Add("ServiceVersion", typeof(int));
            dataTable.Columns.Add("ServiceDescription", typeof(string));
            dataTable.Columns.Add("ServiceAdditionDate", typeof(DateTime));
            dataTable.Columns.Add("ServiceFilePath", typeof(string));

            if (serviceinformation != null)
            {
                dataTable.Rows.Add(serviceinformation.ServiceName, serviceinformation.ServiceVersion, serviceinformation.ServiceDescription, serviceinformation.ServiceAdditionDate, serviceinformation.ServiceFilePath);
            }

            string procedure = "[dbo].[InsertServiceinformation]";
            InsertServiceinformation(procedure, dataSource, dataTable);
        }

        private static void InsertServiceinformation(string procedure, string dataSource, DataTable dataTable)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection(dataSource))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(procedure, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter sqlParameter = sqlCommand.Parameters.AddWithValue("@ServiceinformationTable", dataTable);
                    sqlParameter.SqlDbType = SqlDbType.Structured;
                    sqlParameter.TypeName = "[dbo].[ttServiceDetails]";
                    
                    int updateStatus = sqlCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // Log to DB.
            }
        }

        public void DeleteServiceinformation() 
        { 
        
        }
    }
}
