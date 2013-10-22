using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

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
            //Config.xml wahrscheinlich nur vorübergehend, da wahrscheinlich SQLite besser ist. --> Viktors Task.
            GlobalVariables.configPath = GetApplicationsPath() + "\\config.xml";

            //Checkt ob Config.XML vorhanden ist, wenn ja liest er die Sprache aus
            if (File.Exists(GlobalVariables.configPath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(GlobalVariables.configPath);

                XmlNode language = doc.SelectSingleNode("/settings/language");
                GlobalVariables.language = language.InnerText;
            }
            //Wenn Config.XML im Umgebungsverzeichnis nicht vorhanden ist, erstellt er eine und trägt die Standardsprache DE ein
            else
            {
                XmlDocument doc = new XmlDocument();
                XmlNode settings, language;

                //Root Element einfügen
                settings = doc.CreateElement("settings");
                doc.AppendChild(settings);

                language = doc.CreateElement("language");               
                language.InnerText = "de";          

                //Unterknoten an Root Knoten anhängen
                settings.AppendChild(language);

                //XML Dokument speichern
                doc.Save(GlobalVariables.configPath);

                GlobalVariables.language = "de";
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
            FileInfo fi = new FileInfo(Assembly.GetEntryAssembly().Location);
            return fi.DirectoryName;
        } 
    }


    internal static class GlobalVariables
    {
        internal static string configPath = null;
        internal static string language = "en";
    }
}
