using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrdEditor.Controls
{
    /// <summary>
    /// A program saját - SQLite-os - adatbázisának a kezelője.
    /// </summary>
    class ConfigDatabaseControl
    {
        private static ConfigDatabaseControl instance;
        private SQLiteConnection connection;

        public static ConfigDatabaseControl getInstance()
        {
            if (instance == null)
            {
                instance = new ConfigDatabaseControl();
            }
            return instance;
        }

        protected ConfigDatabaseControl()
        {
            initConnection();
        }
        
        private void initConnection()
        {
            connection = new SQLiteConnection("Data Source=config.db; Version=3; New=True; Compress=True;");
            //connection.Open();
            //string sql = "create table highscores (name varchar(20), score int)";
            //SQLiteCommand command = new SQLiteCommand(sql, connection);
            //command.ExecuteNonQuery();
            //string sql2 = "insert into highscores (name, score) values ('Me', 9001)";
            //SQLiteCommand command2 = new SQLiteCommand(sql2, connection);
            //command2.ExecuteNonQuery();
            //connection.Close();
        }                

        //getters/setters -----------------------------------------------------
        #region
        
        #endregion
    }
}
