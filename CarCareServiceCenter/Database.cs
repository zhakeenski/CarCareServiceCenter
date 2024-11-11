using System;
using System.Data.SqlClient;

namespace CarCareServiceDB
{
    public class Database
    {
        private readonly string connectionString = "Server=KZ070BRO12;Database=CarCareServiceDB;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                // Здесь можно добавить логирование или обработку ошибок
            }
            return connection;
        }

        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
