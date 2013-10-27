using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ibsys2tool
{
    class DbAccess
    {
        private static SQLiteConnection _connection;

        public DbAccess()
        {
            _connection = new SQLiteConnection { ConnectionString = "Data Source=" + GlobalVariables.Sqlitedb };
            _connection.Open();
        }

        public void CloseConnection()
        {
            _connection.Close();
            _connection.Dispose();
        }

        public string GetLanguage()
        {
            string language = "";
            var command = new SQLiteCommand { Connection = _connection };

            // Auslesen der Sprache.
            command.CommandText = "SELECT id, name, value FROM config WHERE name = 'Language'";

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                language = reader[2].ToString();
            }

            // Beenden des Readers und Freigabe aller Ressourcen.
            reader.Close();
            reader.Dispose();

            command.Dispose();

            return language;
        }

        public void CreateTables()
        {
            var command = new SQLiteCommand { Connection = _connection };

            // Erstellen der Config-Tabelle, sofern diese noch nicht existiert.
            command.CommandText = "CREATE TABLE IF NOT EXISTS config ( id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name VARCHAR(100) NOT NULL, value VARCHAR(100) NOT NULL);";
            command.ExecuteNonQuery();

            // Einfügen der Sprache
            command.CommandText = "INSERT INTO config (id, name, value) VALUES(NULL, 'Language', 'de')";
            command.ExecuteNonQuery();

            // Freigabe der Ressourcen.
            command.Dispose();
        }

        public void SqlCommand(string sqlStatement)
        {
            var command = new SQLiteCommand { Connection = _connection };
            command.CommandText = sqlStatement;
            command.ExecuteNonQuery();
            command.Dispose();
        }

    }
}
