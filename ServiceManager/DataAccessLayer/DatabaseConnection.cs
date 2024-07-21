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
    public static class DatabaseConnection
    {
        public static SqlConnection GetConnection(string dataSource)
        {
            return CreateConnection(dataSource);
        }

        private static SqlConnection CreateConnection(string dataSource)
        {
            dataSource = "Data Source=(local);" + dataSource + "Integrated Security=SSPI;Encrypt=False";
            SqlConnection conn = new SqlConnection(dataSource);
            return conn;
        }
    }
}
