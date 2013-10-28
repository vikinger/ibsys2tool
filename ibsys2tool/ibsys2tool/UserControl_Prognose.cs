using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ibsys2tool.XML;


namespace ibsys2tool
{
    public partial class UserControl_Prognose : UserControl
    {
        public UserControl_Prognose()
        {
            InitializeComponent();
        }

        private void btnOpenXml_Click(object sender, EventArgs e)
        {
            LoadXML xml = new LoadXML();
            string pfad = null;
            //Öffnet OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.OpenFile() != null)
                {
                    //Öffnet Explorer und ermittelt den Eingegebenen Dateipfad
                    string file = openFileDialog1.FileName;
                    try
                    {
                        pfad = openFileDialog1.FileName;
                    }
                    //TODO: Ausnahme hinzufügen
                    catch (IOException)
                    {

                    }
                }
                //Dateipfad wird an die Klasse ladeXML übergeben
                Console.WriteLine(result);
                Console.WriteLine(pfad);
                xml.ladeXML(pfad);

            }
        }

        private void tbPathToXml_TextChanged(object sender, EventArgs e)
        {
            //Wenn Pfad-Textbox leer, ist "Berechnen" nicht möglich
            if(!String.IsNullOrEmpty(tbPathToXml.Text))
                btnCalculate.Enabled = true;
            else
                btnCalculate.Enabled = false;
        }
    }
}
