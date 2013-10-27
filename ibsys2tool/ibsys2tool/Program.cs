using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ibsys2tool
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalVariables.SqlitedbPath = GetApplicationsPath() + "\\" + GlobalVariables.Sqlitedb;

            //Checkt ob SQLite.db vorhanden ist, wenn ja liest er die Sprache aus
            if (File.Exists(GlobalVariables.SqlitedbPath))
            {
                var dbAccess = new DbAccess();
                GlobalVariables.Language = dbAccess.GetLanguage();
                dbAccess.CloseConnection();
            }
            else
            {
                var dbAccess = new DbAccess();
                dbAccess.CreateTables();
                dbAccess.CloseConnection();
            }

            //öffnet den Startbildschirm
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static string GetTitle()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }

        public static string GetApplicationsPath()
        {
            var fi = new FileInfo(Assembly.GetEntryAssembly().Location);
            return fi.DirectoryName;
        } 
    }


    internal static class GlobalVariables
    {
        internal static string Language = "en";
        internal static string SqlitedbPath = null;
        internal static string Sqlitedb = "SQLite.db";
    }
}
