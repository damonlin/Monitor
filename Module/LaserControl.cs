using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CommunicationInterface;

namespace ContrelModule
{
    public partial class LaserControl : UserControl
    {      
        #region Ctor
        public LaserControl()
        {
            InitializeComponent();

            //LaserCMD.LaserInitial();                    
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //LaserCMD.CheckLaserStatus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //if (LaserCMD.Stop())
            //    MessageBox.Show("Stop OK");
            //else
            //    MessageBox.Show("Stop NG");
        }
    }      
}
