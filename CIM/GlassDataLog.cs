using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CIM
{
    public partial class GlassDataLog : Common.Template.SubInfoPanelTemplate
    {
        public GlassDataLog()
        {
            InitializeComponent();
        }

        private void selectLogFileFolderButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader tmpreader = new StreamReader(openFileDialog1.FileName);
                historyLogTextBox.Text = tmpreader.ReadToEnd();
                logFolderTextBox.Text = openFileDialog1.FileName;
            }
        }
    }
}
