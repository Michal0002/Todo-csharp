using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class DatabaseManager
    {
        private static string connectionString = "Data Source=tasks.db;";
        public static void CreateDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"CREATE TABLE IF NOT EXISTS Tasks (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    name TEXT NOT NULL,
                                    description TEXT,
                                    priority INTEGER,
                                    deadline DATE,
                                    completed INTEGER DEFAULT 0
                                )";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static DataTable GetAllTasks()
        {
            DataTable dtTasks = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, name, description, priority, deadline, completed FROM Tasks";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                adapter.Fill(dtTasks);

                connection.Close();
            }

            return dtTasks;
        }

        public static void InsertTask(string name, string description, int priority, DateTime? deadline)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Tasks (name, description, priority, deadline) 
                                 VALUES (@Name, @Description, @Priority, @Deadline)";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Priority", priority);
                command.Parameters.AddWithValue("@Deadline", deadline);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

    }
}