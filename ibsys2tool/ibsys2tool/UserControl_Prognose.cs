using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Öffnet OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.OpenFile() != null)
                {
                    tbPathToXml.Text = openFileDialog1.FileName;
                }
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
