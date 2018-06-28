using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            comboBox_OutputType.Items.AddRange(new object[] { "Aerotech, Dielectric, JPSA" });
        }

        private void button_SelectFolder_Click(object sender, EventArgs e)
        {

        }
    }
}
