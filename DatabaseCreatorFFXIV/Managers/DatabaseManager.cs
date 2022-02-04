using System;
using System.Data.SQLite;

namespace DatabaseCreatorFFXIV.Managers
{
    public class DatabaseManager
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        
        public DatabaseManager()
        {
            // SQLiteConnection conn = new SQLiteConnection("Data Source=database.db");
            // SQLiteConnection.CreateFile("database.db");
            // conn.Open();
            // SQLiteCommand a = new SQLiteCommand(@"CREATE TABLE contacts (first_name TEXT NOT NULL,);", conn);
            // a.ExecuteNonQuery();
            // conn.Close();
        }

        ~DatabaseManager() => connection?.Close();
    }
}