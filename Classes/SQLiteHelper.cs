using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace WpfWDSS.Classes
{
    internal class SQLiteHelper
    {
        private SQLiteConnection connection;


        public SQLiteHelper(string connectionString)
        {
            connection = new SQLiteConnection(connectionString);
        }

        public bool CheckUserCredentials(string Login, string password)
        {
            bool result = false;

            string query = "SELECT COUNT(*) FROM Users WHERE Login=@Login AND Password=@password";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    result = true;
                }

                connection.Close();
            }

            return result;
        }
    }
}
