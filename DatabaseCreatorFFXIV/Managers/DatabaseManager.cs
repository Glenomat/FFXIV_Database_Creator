using System.ComponentModel;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace DatabaseCreatorFFXIV.Managers
{
    public class DatabaseManager
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private string tableName = "";

        public void CreateDatabase(string dir, string fileName)
        {
            var path = $"/{dir}/{fileName}";
            
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            if(File.Exists(path))
                File.Delete(path);
            
            SQLiteConnection.CreateFile(Application.StartupPath + "/" + path);
            
            connection = new SQLiteConnection($"Data Source={Application.StartupPath + "/" + path}");
            connection.Open();

            command = connection.CreateCommand();
            
            tableName = fileName.Remove(fileName.IndexOf("."),3);
            
            command.CommandText = $@"CREATE TABLE ""{tableName}""(""Name"" TEXT,""Id"" TEXT,""Link"" TEXT);";
            
            command.ExecuteNonQuery();
        }

        public void AddDatabaseEntry(string name, string id, string link)
        {
            command.CommandText =
                $@"
                INSERT INTO {tableName} (""Name"", ""Id"", ""Link"")
                VALUES (""{name}"", ""{id}"", ""{link}"");
                ";
            command.ExecuteNonQuery();
        }
        
        public void CloseDatabase() => connection?.Close();
    }
}