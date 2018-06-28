using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUI
{
    public partial class Main : Form
    {
        //initialises an instance of the editor form
        public MacroEdit.MacroEditor macroEditor  =  new MacroEdit.MacroEditor();

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        

        /// <summary>
        /// This initialises the main UI
        /// </summary>
        public Main()
        {
            InitializeComponent();

            //sets opens for combo box
            comboBox_OutputType.Items.AddRange(new object[] { "Aerotech", "Dielectric", "JPSA", "Default" });
        }

        /// <summary>
        /// Selects the folder used for save directory for output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SelectFolder_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// stops user from editting combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_OutputType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// brings up the macro editor window without any loaded data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CreateMacro_Click(object sender, EventArgs e)
        {
            macroEditor.ShowDialog();
        }

        private void button_OpenMacro_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Base Macro files(*.mac) | *.mac";
                        
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text=File
                }
                catch(IOException)
                {

                }
                
            }
        }
    }
}
