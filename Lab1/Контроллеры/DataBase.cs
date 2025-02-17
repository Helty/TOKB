﻿using System.Data.SqlClient;

namespace TOKB
{
    class DataBase
    {
        SqlConnection connection = new SqlConnection("Data Source=ANDREW\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
