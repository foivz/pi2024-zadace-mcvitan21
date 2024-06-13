using System;
using System.Data.SqlClient;

namespace DBLayer
{
    public static class Database
    {
        private static string _connectionString = @"Data Source=31.147.206.65,1433;Initial Catalog=PI2324_mcvitan21_DB;User ID=PI2324_mcvitan21_User;Password=G45:$ddf;";
        private static SqlConnection _connection;

        public static void OpenConnection()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public static void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }

        public static SqlDataReader GetDataReader(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteReader();
        }

        public static int ExecuteCommand(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, _connection);
            return command.ExecuteNonQuery();
        }

        public static SqlConnection Connection
        {
            get { return _connection; }
        }
    }
}
