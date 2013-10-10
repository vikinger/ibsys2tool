using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibsys2tool
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            string title = GetAssemblyAttribute<AssemblyTitleAttribute>(a => a.Title);
            string copyright = GetAssemblyAttribute<AssemblyCopyrightAttribute>(a => a.Copyright);
            string company = GetAssemblyAttribute<AssemblyCompanyAttribute>(a => a.Company);
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string description = GetAssemblyAttribute<AssemblyDescriptionAttribute>(a => a.Description);

            richTextBox1.Text = "\n  " +title + "\n\n  " + company + "\n\n  " + description +
                "\n\n  " + copyright + "\n\n  Version: " + version;
            
        }

        public string GetAssemblyAttribute<T>(Func<T, string> value)
where T : Attribute
        {
            T attribute = (T)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(T));
            return value.Invoke(attribute);
        }
    }
}
