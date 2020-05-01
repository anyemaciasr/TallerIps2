using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace Datos
{
    public class ConnectionManager
    {
        internal SqlConnection Conexion;
        public ConnectionManager(string connectionString)
        {
            Conexion = new SqlConnection(connectionString);
        }
        public void Open()
        {
            Conexion.Open();
        }
        public void Close()
        {
            Conexion.Close();
        }

    }
 }
