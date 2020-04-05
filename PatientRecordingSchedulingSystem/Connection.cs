using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PatientRecordingSchedulingSystem
{
    class Connection
    {
        private SqlConnection connection;

        public Connection(string databaseName)
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Server=.\SQLEXPRESS;Integrated Security=SSPI;Database=" + databaseName;
        }

        private Exception DBFail()
        {
            return new Exception("Can't connect to the DB.");
        }

        private Exception CommandFail()
        {
            return new Exception("Cannot process command.");
        }

        public bool VerifyAccount(string username, string password, string account_type)
        {
            bool accountExists = false;

            try
            {
                connection.Open();

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "VerifyAccount";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@account_type", account_type);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() && reader.GetInt32(0) == 1)
                        accountExists = true;

                    connection.Close();
                }
                catch { throw CommandFail(); }

            }
            catch { throw DBFail(); }

            return accountExists;
        }
    }
}
