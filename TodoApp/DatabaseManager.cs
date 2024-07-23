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
                                name TEXT NOT NULL UNIQUE,
                                description TEXT,
                                priority TEXT CHECK(priority IN ('Low', 'Medium', 'High')),
                                deadline DATE,
                                completed INTEGER DEFAULT 0 CHECK(completed IN (0, 1))
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
        public static DataTable GetLowPriorityTasks()
        {
            DataTable dtTasks = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, name, description, priority, deadline, completed " +
                               "FROM Tasks " +
                               "WHERE priority = 'Low'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                adapter.Fill(dtTasks);

                connection.Close();
            }

            return dtTasks;
        }
        public static DataTable GetMediumPriorityTasks()
        {
            DataTable dtTasks = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, name, description, priority, deadline, completed " +
                               "FROM Tasks " +
                               "WHERE priority = 'Medium'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                adapter.Fill(dtTasks);

                connection.Close();
            }

            return dtTasks;
        }
        public static DataTable GetHighPriorityTasks()
        {
            DataTable dtTasks = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, name, description, priority, deadline, completed " +
                               "FROM Tasks " +
                               "WHERE priority = 'High'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                adapter.Fill(dtTasks);

                connection.Close();
            }

            return dtTasks;
        }
        public static DataTable GetCompletedTasks()
        {
            DataTable dtTasks = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, name, description, priority, deadline, completed " +
                               "FROM Tasks " +
                               "WHERE completed = 1";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                adapter.Fill(dtTasks);

                connection.Close();
            }

            return dtTasks;
        }
        public static DataTable GetUncompletedTasks()
        {
            DataTable dtTasks = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, name, description, priority, deadline, completed " +
                               "FROM Tasks " +
                               "WHERE completed = 0";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                adapter.Fill(dtTasks);

                connection.Close();
            }

            return dtTasks;
        }

        public static void InsertTask(string name, string description, string priority, DateTime deadline)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Tasks (name, description, priority, deadline, completed) " +
                               "VALUES (@name, @description, @priority, @deadline, 0)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@deadline", deadline);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void UpdateTask(int id, string name, string description, string priority, DateTime deadline)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Tasks SET name = @name, description = @description, priority = @priority, deadline = @deadline " +
                               "WHERE id = @id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@deadline", deadline);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void DeleteTask(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Tasks WHERE id = @id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

    }
}