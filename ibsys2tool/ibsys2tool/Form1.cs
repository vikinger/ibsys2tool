using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace ibsys2tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Hier müsste der Wert aus der SQLite Datenbank genommen werden - nur provisorisch
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(GlobalVariables.Language);
            InitializeComponent();
        }

        private void sCSimStartseiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.scsim.de");
        }

        private void infoÜberToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void btnPrognose_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var myControl = new ibsys2tool.UserControl_Prognose();
            splitContainer1.Panel2.Controls.Add(myControl);
        }

        private void btnDisposition_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var myControl = new ibsys2tool.UserControl_Disposition();
            splitContainer1.Panel2.Controls.Add(myControl);
        }

        private void btnKapazitätsplan_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var myControl = new ibsys2tool.UserControl_Kapazitätsplan();
            splitContainer1.Panel2.Controls.Add(myControl);
        }

        private void btnBestellverwaltung_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var myControl = new ibsys2tool.UserControl_Bestellverwaltung();
            splitContainer1.Panel2.Controls.Add(myControl);
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var myControl = new ibsys2tool.UserControl_Xml();
            splitContainer1.Panel2.Controls.Add(myControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            var myControl = new ibsys2tool.UserControl_Prognose();
            splitContainer1.Panel2.Controls.Add(myControl);
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dbAccess = new DbAccess();
            dbAccess.SqlCommand("UPDATE config SET value = 'de' WHERE name = 'Language'");
            dbAccess.CloseConnection();

            GlobalVariables.Language = "de";

            Application.Restart();
        }

        private void englischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dbAccess = new DbAccess();
            dbAccess.SqlCommand("UPDATE config SET value = 'en' WHERE name = 'Language'");
            dbAccess.CloseConnection();

            GlobalVariables.Language = "en";

            Application.Restart();
        }

    }
}
