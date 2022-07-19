using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace ADO.NETCORE.DbConfig
{
    public class ConnectDb
    {
        public SqlConnection sql { get; }
        public ConnectDb()
        {
            sql = new SqlConnection(ConnectionString.ConnectionStr);
        }
    }
    public class ConnectionString
    {
        public static string ConnectionStr { get; set; }
    }
}
