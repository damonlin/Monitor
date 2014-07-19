using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ContrelModule
{
    public partial class LaserParaAdjust : UserControl
    {
        public LaserParaAdjust()
        {
            InitializeComponent();
        }

        private void m_chbFilterOn_CheckedChanged(object sender, EventArgs e)
        {
            //CCLaserInterface.getSingleton().SetColorFilter(true);
        }

        private void m_radioClockwise_CheckedChanged(object sender, EventArgs e)
        {
            //CCLaserInterface.getSingleton().SetColorFilterAngle(400);
        }

        private void m_btnMiddleSpeed_Click(object sender, EventArgs e)
        {
            //CCLaserInterface.getSingleton().SetColorFilterAngle(40);
        }

        private void m_btnLowSpeed_Click(object sender, EventArgs e)
        {
            //CCLaserInterface.getSingleton().SetColorFilterAngle(4);
        }
    }
}
