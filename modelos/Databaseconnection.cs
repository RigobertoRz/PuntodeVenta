using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ProyectoTienda.modelos
{
    

    public static class DatabaseConnection
    {
        private static readonly string connectionString =
            "Driver={ODBC Driver 17 for SQL Server};" +
            "Server=VAZZLAP\\SQLEXPRESS;" +
            "Database=Tienda;" +
            "UID=rigo;" +
            "PWD=123;";

        public static OdbcConnection GetConnection()
        {
            return new OdbcConnection(connectionString);
        }
    }
}
