using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace world_of_typing
{
    internal class Database
    {
        private static readonly string connectionString = @"Data Source=Database\db.sqlite;Version=3;";

        public static void GenerateDb()
        {
            using SQLiteConnection connection = new(connectionString);
            connection.Open();

            SQLiteCommand createTableCommand = new(
                @"CREATE TABLE IF NOT EXISTS Users (
                    id INTEGER PRIMARY KEY,
                    name TEXT UNIQUE,
                    score INTEGER
                );",
                connection
            );
            createTableCommand.ExecuteNonQuery();
            connection.Close();
            Transfer();
        }


        public static void GenerateUser(string name)
        {
            using SQLiteConnection connection = new(connectionString);
            connection.Open();

            SQLiteCommand insertCommand = new(
                @"INSERT OR IGNORE INTO Users (name, score)
                  VALUES (@name, @score);",
                connection
            );
            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@score", null);
            insertCommand.ExecuteNonQuery();

            connection.Close();
            Transfer();
        }

        public static void UpdateScore(string name, int newScore)
        {
            using SQLiteConnection connection = new(connectionString);
            connection.Open();

            SQLiteCommand updateCommand = new(
                @"UPDATE Users
                  SET score = @newScore
                  WHERE name = @name AND (score < @newScore OR score IS NULL);",
                connection
            );
            updateCommand.Parameters.AddWithValue("@name", name);
            updateCommand.Parameters.AddWithValue("@newScore", newScore);
            updateCommand.ExecuteNonQuery();

            connection.Close();
            Transfer();
        }

        public static Dictionary<string, (string? name, int? score)> GetAllUsers()
        {
            Dictionary<string, (string? name, int? score)> users = [];

            using SQLiteConnection connection = new(connectionString);
            connection.Open();

            SQLiteCommand selectCommand = new("SELECT name, score FROM Users;", connection);
            using SQLiteDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString() ?? "";
                int? score = reader["score"] != DBNull.Value ? Convert.ToInt32(reader["score"]) : null;

                users[name] = (name, score);
            }

            connection.Close();

            Dictionary<string, (string? name, int? score)> sortedUsers = users.OrderByDescending(user => user.Value.score)
                                       .ThenBy(user => user.Value.name)
                                       .ToDictionary(user => user.Key, user => user.Value);

            return sortedUsers;
        }

        private static void Transfer()
        {
            string outputFolderDatabasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "db.sqlite");
            string? projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName;
            string targetDirectory = Path.Combine(projectDirectory ?? "", "Database");
            string targetFilePath = Path.Combine(targetDirectory, "db.sqlite");
            File.Copy(outputFolderDatabasePath, targetFilePath, overwrite: true);
        }
    }
}
